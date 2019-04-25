``` ini

BenchmarkDotNet=v0.11.5, OS=macOS Mojave 10.14.1 (18B75) [Darwin 18.2.0]
Intel Core i5-3210M CPU 2.50GHz (Ivy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.504
  [Host]     : .NET Core 2.1.8 (CoreCLR 4.6.27317.03, CoreFX 4.6.27317.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.8 (CoreCLR 4.6.27317.03, CoreFX 4.6.27317.03), 64bit RyuJIT


```
|                Method |      Mean |    Error |    StdDev |    Median |
|---------------------- |----------:|---------:|----------:|----------:|
|        BenchmarkRegex | 163.22 us | 4.538 us | 12.725 us | 159.07 us |
| BenchmarkLoopingChars |  91.96 us | 1.832 us |  4.174 us |  91.47 us |
