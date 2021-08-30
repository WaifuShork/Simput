<h1 align="center" style="position: relative;">
    <img width="200" style="border-radius: 50%;" src="assets/logo.png" alt="SimpleInputs"/><br>
    Simple Inputs
</h1>


<img alt="Travis (.com)" src="https://img.shields.io/travis/com/yiliansource/brackeys-bot">

# Features
This is a basic .NET 5.0 Library for simple console inputs of all values, its basically a TryParse under the hood, handling all the tedius stuff for you!

This library brings a mix of how Python and Java handle inputs for non-string values. As of right now it only works with the console!

## Why bother with making this? 
I'm always making console apps so this is a must for me! Its must easier than constantly making TryParse statements, or even setting up a new method system for each project!

## Installation
You can find the NuGet Package [here](https://www.nuget.org/packages/SimpleInputs/1.1.0).

You can also build from source by running ```dotnet build```, and then including the DLL as a reference in your project.

Most IDEs allow you to: ```Right click csproj -> dependencies/references -> add reference```

Or alternatively they have: ```Dependencies -> add dependency/reference -> locate reference by file location```

## Documentation

```c#
using SimpleInputs;

private static void Main()
{
    var input = Input.NextDecimal(output: "Enter Value", warning: "Wrong value!");
    var input = Input.NextDouble(output: "Enter Value", warning: "Wrong value!");
    var input = Input.NextFloat(output: "Enter Value", warning: "Wrong value!");
    var input = Input.NextInt(output: "Enter Value", warning: "Wrong value!");
    var input = Input.NextLong(output: "Enter Value", warning: "Wrong value!");
    var input = Input.NextSByte(output: "Enter Value", warning: "Wrong value!");
    var input = Input.NextShort(output: "Enter Value", warning: "Wrong value!");
    var input = Input.NextUInt(output: "Enter Value", warning: "Wrong value!");
    var input = Input.NextULong(output: "Enter Value", warning: "Wrong value!");
    var input = Input.NextUShort(output: "Enter Value", warning: "Wrong value!");
    
    // OR
    var input = Input.Next<decimal>(output: "Enter Value", warning: "Wrong value!");
    var input = Input.Next<double>(output: "Enter Value", warning: "Wrong value!");
    var input = Input.Next<float>(output: "Enter Value", warning: "Wrong value!");
    var input = Input.Next<int>(output: "Enter Value", warning: "Wrong value!");
    var input = Input.Next<long>(output: "Enter Value", warning: "Wrong value!");
    var input = Input.Next<sbyte>(output: "Enter Value", warning: "Wrong value!");
    var input = Input.Next<short>(output: "Enter Value", warning: "Wrong value!");
    var input = Input.Next<uint>(output: "Enter Value", warning: "Wrong value!");
    var input = Input.Next<ulong>(output: "Enter Value", warning: "Wrong value!");
    var input = Input.Next<ushort>(output: "Enter Value", warning: "Wrong value!");
}
```

### Do I plan on adding anything else?
A of right now I have no idea on what else to create for this library. 
But if you'd like to contribute, or suggest features, feel free to create a new [issue](https://github.com/WaifuShork/SimpleInputs/issues).