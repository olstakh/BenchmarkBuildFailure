// --------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// --------------------------------------------------------------

using BenchmarkDotNet.Running;

namespace Microsoft.FrontlineWorker.Service.Benchmark;

public class Program
{
    public static void Main(string[] args) =>

        // Make sure to run it in release mode
        // Example: dotnet run --project Microsoft.FrontlineWorker.Service.Benchmark.csproj -c Release --filter * --disableLogFile --join --envVars ASPNETCORE_ENVIRONMENT:Development
        BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
}
