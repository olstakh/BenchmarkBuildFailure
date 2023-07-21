// --------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// --------------------------------------------------------------

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Benchmark;

[SimpleJob(RunStrategy.ColdStart, iterationCount: 1)]
public class TestBenchmark
{
    [Benchmark(OperationsPerInvoke = 1)]
    public void Test()
    {
        Thread.Sleep(10);
    }
}
