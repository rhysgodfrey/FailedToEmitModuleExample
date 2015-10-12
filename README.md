# Example of "Failed to Emit Module Example"

Example repository showing the "CS7038: Failed to Emit Module" build error - [Roslyn Issue 4196](https://github.com/dotnet/roslyn/issues/4196).

The issue occurs when calling a method with default parameters in a referenced assembly that was Obfuscated using Red Gate Smart Assembly 6.8 (and possibly lower), and building using the Roslyn compiler built into the Visual Studio 2015 RTM.

__Obfuscating the assembly using Red Gate Smart Assembly 6.9 fixes the build error.__

## Fix Available
The Roslyn team have fixed this issue as part of [Visual Studio 2015 Update 1](https://www.visualstudio.com/en-us/news/vs2015-update1-vs.aspx) (currently available as a CTP).

## Example Setup

This example is a minimal solution to show the error.

The `FailedToEmitModuleExample.Obfuscated` project has been obfuscated with both Smart Assembly 6.8.0.121 and 6.9.0.114 (in the obfuscated folder).

The `master` branch references the assembly obfuscated with version 6.8, this will fail to build in Visual Studio 2015 RTM (but will build in VS 2015 RC or earlier VS versions).

The `smart-assembly-6.9` branch references the assembly obfuscated with  version 6.9 which builds correctly.
