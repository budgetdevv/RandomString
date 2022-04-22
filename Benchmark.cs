using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmark
{
    //[MemoryDiagnoser]
    [DisassemblyDiagnoser(exportCombinedDisassemblyReport: true)]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]  
    public unsafe class Benchmark
    {
        private Random Rand;

        private const int RandStrLength = 1000;
        
        //private const string CharPool = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-_@!#$%^&*()+{}[]";

        private string CharPool;
        
        private StringBuilder SB;
        
        private delegate*<int, string> AllocString;
        
        //https://www.asciitable.com/
        const char CharPoolASCIIStart = (char) 64, CharPoolASCIIEnd = (char) 125;
        
        [GlobalSetup]
        public void GlobalSetup()
        {
            Rand = new Random(DateTime.UtcNow.Millisecond);

            var CharPoolSize = CharPoolASCIIEnd - CharPoolASCIIStart + 1;

            var CharPoolArr = new char[CharPoolSize];

            var CurrentASCII = CharPoolASCIIStart;
            
            for (int I = 0; I < CharPoolArr.Length; I++)
            {
                CharPoolArr[I] = CurrentASCII++;
            }

            CharPool = new string(CharPoolArr);
            
            SB = new StringBuilder(RandStrLength);

            SB.Length = RandStrLength;
            
            var Method = typeof(string).GetMethod("FastAllocateString", BindingFlags.NonPublic | BindingFlags.Static)!;

            AllocString = (delegate*<int, string>) Method.MethodHandle.GetFunctionPointer();
        }

        //[Benchmark(Baseline = true)]
        public string RandomStringsUsingStringBuilder()
        {
            for (int i = 0; i < RandStrLength; i++)
            {
                SB[i] = CharPool[Rand.Next(0, CharPool.Length)];
            }

            return SB.ToString();
        }
        

        [Benchmark]
        public string RandomStringsUsingStringDotCreateConstAlphaStaticRandom()
        {
            return string.Create(RandStrLength, Rand, (buff, rand) =>
            {
                for (int i = 0; i < buff.Length; i++)
                {
                    buff[i] = CharPool[rand.Next(0, CharPool.Length)];
                }
            });
        }

        //[Benchmark]
        public string RandomStringAkari()
        {
            var str = stackalloc char[RandStrLength];
            for (var i = 0; i < RandStrLength; i++)
            {
                (*str++) = CharPool[Rand.Next(0, CharPool.Length)];
            }

            return new string(str, 0, RandStrLength);
        }

        [Benchmark]
        public string RandStrTrumpMcD()
        {
            var rand = Rand;
            
            var RandStr = AllocString(RandStrLength);

            ref var Current = ref MemoryMarshal.GetReference(RandStr.AsSpan());

            ref var LastOffsetByOne = ref Unsafe.Add(ref Current, RandStrLength);

            var CharPoolLength = CharPool.Length;
                
            ref var CharPoolFirst = ref MemoryMarshal.GetReference(CharPool.AsSpan());
                
            for (; !Unsafe.AreSame(ref Current, ref LastOffsetByOne); Current = ref Unsafe.Add(ref Current, 1))
            {
                var Index = rand.Next(0, CharPoolLength);

                Current = Unsafe.Add(ref CharPoolFirst, Index);
            }
            return RandStr;
        }

        [Benchmark]
        public string RandStrTrumpMcD2()
        {
            return string.Create(RandStrLength, Rand, (RandStrSpan, rand) =>
            {
                ref var Current = ref MemoryMarshal.GetReference(RandStrSpan);

                ref var LastOffsetByOne = ref Unsafe.Add(ref Current, RandStrLength);

                var CharPoolLength = CharPool.Length;
                
                ref var CharPoolFirst = ref MemoryMarshal.GetReference(CharPool.AsSpan());
                
                for (; !Unsafe.AreSame(ref Current, ref LastOffsetByOne); Current = ref Unsafe.Add(ref Current, 1))
                {
                    var Index = rand.Next(0, CharPoolLength);

                    Current = Unsafe.Add(ref CharPoolFirst, Index);
                }
            });
        }
        
        [Benchmark]
        public string RandStrTrumpMcD3()
        {
            var rand = Rand;
            
            var RandStr = AllocString(RandStrLength);

            ref var Current = ref MemoryMarshal.GetReference(RandStr.AsSpan());

            ref var LastOffsetByOne = ref Unsafe.Add(ref Current, RandStrLength);

            for (; !Unsafe.AreSame(ref Current, ref LastOffsetByOne); Current = ref Unsafe.Add(ref Current, 1))
            {
                const int Min = CharPoolASCIIStart, Max = CharPoolASCIIEnd + 1;

                Current = unchecked((char) rand.Next(Min, Max));
            }
            return RandStr;
        }
    }
}
