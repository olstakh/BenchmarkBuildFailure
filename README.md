# BenchmarkBuildFailure
Short repro of build failure after upgrading benchmarkdotnet from 0.13.5 to 0.13.6

# Repro
Run
```
dotnet run -c Release --filter *
```
from the root

Observe many nuget warnings that are treated as errors, breaking the build.
Change BenchmarkVersion variable in Packages.Prop to 0.13.5, instead of 0.13.6, run the above command and observe no errors and benchmark executing
