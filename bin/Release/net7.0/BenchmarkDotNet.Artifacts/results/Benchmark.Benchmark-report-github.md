``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19044
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=7.0.100-preview.2.22153.17
  [Host]     : .NET Core 7.0.0 (CoreCLR 7.0.22.15202, CoreFX 7.0.22.15202), X64 RyuJIT
  DefaultJob : .NET Core 7.0.0 (CoreCLR 7.0.22.15202, CoreFX 7.0.22.15202), X64 RyuJIT


```
|                                                  Method |     Mean |     Error |    StdDev | Code Size |
|-------------------------------------------------------- |---------:|----------:|----------:|----------:|
|                                         RandStrTrumpMcD | 9.177 μs | 0.0622 μs | 0.0551 μs |     134 B |
|                                        RandStrTrumpMcD2 | 9.339 μs | 0.0676 μs | 0.0633 μs |     430 B |
| RandomStringsUsingStringDotCreateConstAlphaStaticRandom | 9.663 μs | 0.0390 μs | 0.0326 μs |     438 B |
