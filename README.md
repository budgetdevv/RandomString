# Random strings

``` ini

// * Summary *

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19043
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=7.0.100-preview.2.22153.17
[Host]     : .NET Core 7.0.0 (CoreCLR 7.0.22.15202, CoreFX 7.0.22.15202), X64 RyuJIT
DefaultJob : .NET Core 7.0.0 (CoreCLR 7.0.22.15202, CoreFX 7.0.22.15202), X64 RyuJIT
  
```

|                                                  Method |     Mean |    Error |   StdDev |   Median | Code Size |
|-------------------------------------------------------- |---------:|---------:|---------:|---------:|----------:|
|                                        RandStrTrumpMcD3 | 13.70 us | 0.030 us | 0.023 us | 13.70 us |     109 B |
|                                         RandStrTrumpMcD | 13.84 us | 0.044 us | 0.037 us | 13.85 us |     147 B |
|                                        RandStrTrumpMcD2 | 14.62 us | 0.291 us | 0.725 us | 14.26 us |     397 B |
| RandomStringsUsingStringDotCreateConstAlphaStaticRandom | 14.77 us | 0.099 us | 0.088 us | 14.76 us |     404 B |