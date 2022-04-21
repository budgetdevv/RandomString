``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19043
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=7.0.100-preview.2.22153.17
  [Host]     : .NET Core 7.0.0 (CoreCLR 7.0.22.15202, CoreFX 7.0.22.15202), X64 RyuJIT
  DefaultJob : .NET Core 7.0.0 (CoreCLR 7.0.22.15202, CoreFX 7.0.22.15202), X64 RyuJIT


```
|                                                  Method |     Mean |     Error |    StdDev | Code Size |
|-------------------------------------------------------- |---------:|----------:|----------:|----------:|
| RandomStringsUsingStringDotCreateConstAlphaStaticRandom | 1.443 μs | 0.0031 μs | 0.0024 μs |     438 B |
|                                        RandStrTrumpMcD2 | 1.447 μs | 0.0051 μs | 0.0048 μs |     429 B |
