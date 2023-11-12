```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100-rc.1.23463.5
  [Host]     : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2


```
| Method                       | Mean     | Error     | StdDev    | Ratio | Gen0   | Allocated | Alloc Ratio |
|----------------------------- |---------:|----------:|----------:|------:|-------:|----------:|------------:|
| GetFullStringNormally        | 2.661 μs | 0.0514 μs | 0.0528 μs |  1.00 | 5.6725 |  23.18 KB |        1.00 |
| GetFullStringByStringBuilder | 1.116 μs | 0.0189 μs | 0.0202 μs |  0.42 | 0.9937 |   4.06 KB |        0.18 |
