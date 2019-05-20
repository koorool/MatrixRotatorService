# MatrixRotatorService

Simple function to rotate square matrix in memory in O(n) time.

Made in 15 minutes as test task.

``` ini

BenchmarkDotNet=v0.11.5, OS=macOS Mojave 10.14.5 (18F132) [Darwin 18.6.0]
Intel Core i7-6700HQ CPU 2.60GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.2.105
  [Host] : .NET Core 2.2.3 (CoreCLR 4.6.27414.05, CoreFX 4.6.27414.05), 64bit RyuJIT
  Core   : .NET Core 2.2.3 (CoreCLR 4.6.27414.05, CoreFX 4.6.27414.05), 64bit RyuJIT

Job=Core  Runtime=Core  

```
|      Method |     N |       Mean |      Error |    StdDev | Rank |
|------------ |------ |-----------:|-----------:|----------:|-----:|
| **RotateRight** |  **1000** |   **2.338 ms** |  **0.0449 ms** | **0.0420 ms** |    **1** |
| **RotateRight** | **10000** | **776.534 ms** | **10.6688 ms** | **9.4576 ms** |    **2** |
