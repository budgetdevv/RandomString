# Random strings

``` ini

// * Summary *

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19044
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=7.0.100-preview.2.22153.17
  [Host]     : .NET Core 7.0.0 (CoreCLR 7.0.22.15202, CoreFX 7.0.22.15202), X64 RyuJIT
  DefaultJob : .NET Core 7.0.0 (CoreCLR 7.0.22.15202, CoreFX 7.0.22.15202), X64 RyuJIT
  
```

|                                                  Method |     Mean |     Error |    StdDev | Code Size |
|-------------------------------------------------------- |---------:|----------:|----------:|----------:|
|                                         RandStrTrumpMcD | 9.177 us | 0.0622 us | 0.0551 us |     134 B |
|                                        RandStrTrumpMcD2 | 9.339 us | 0.0676 us | 0.0633 us |     430 B |
| RandomStringsUsingStringDotCreateConstAlphaStaticRandom | 9.663 us | 0.0390 us | 0.0326 us |     438 B |