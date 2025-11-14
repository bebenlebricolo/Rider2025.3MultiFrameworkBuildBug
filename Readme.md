# Rider 2025.3 Multiframework build bug Repro repository
This little repository aims to reproduce a build issue that we have with the commercial release of Rider 2025.3 when building a MAUI project with several targeted frameworks.

Here is the bug ticket [[Multi .NET frameworks] Cannot build the whole solution anymore](https://youtrack.jetbrains.com/issue/RIDER-132476/Multi-.NET-frameworks-Cannot-build-the-whole-solution-anymore).

## Repro steps
With a recent Rider IDE (also reproducible with EAP build #RD-253.28294.23, built on November 4, 2025), open the [Rider2025.3MultiFrameworkBuildBug.sln solution](Rider2025.3MultiFrameworkBuildBug.sln) and try a "Full Solution build".
The build will fail because of missing metadata on the MyAppProject.dll (the binaries are not generated.)

## Manual workaround (tested with dotnet sdks CLI >= .net9.0)
Simply run the `dotnet build -c Release` command, and dotnet will take care about building for all required frameworks at once.