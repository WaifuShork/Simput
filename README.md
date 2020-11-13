<h1 align="center" style="position: relative;">
    <img width="200" style="border-radius: 50%;" src="./simpleinputs.png"/><br>
    Simple Inputs Library
</h1>


<img alt="Travis (.com)" src="https://img.shields.io/travis/com/yiliansource/brackeys-bot">

# Simple Inputs Library
This is a basic .NET 5.0 Library for simple console inputs of all values, its basically a TryParse under the hood, handling all the tedius stuff for you!

This library brings a mix of how Python and Java handle inputs for non-string values. As of right now it only works with the console!


## Why bother with making this? 
I'm always making console apps so this is a must for me! Its must easier than constantly making TryParse statements, or even setting up a new method system for each project!

## Installation
You can find the NuGet Package here -> ```https://www.nuget.org/packages/SimpleInputs/1.1.0```.
(I'll try to always keep this updated with the latest version!)

You can also build from source by running ```dotnet build```, and then including the DLL as a reference in your project.

Most IDEs allow you to: ```Right click csproj -> references -> add reference```

Or alternatively they have: ```Dependencies -> add dependency -> locate reference by file location```

## Documentation <img alt="GitHub" src="https://camo.githubusercontent.com/77e7cdcf1992654efde98939841b0312445f3e48/68747470733a2f2f696e63682d63692e6f72672f6173736574732f62616467652d6578616d706c652d62373166396538333333313866363666363462336632333837373131333035312e737667">

```c#
using SimpleInputs;

private static void Main()
{
    // All parameters are optional and have default values
    decimal input = Input.NextDecimal(output: "Enter Value", warning: "Wrong value!");
    double input = Input.NextDouble(output: "Enter Value", warning: "Wrong value!");
    float input = Input.NextFloat(output: "Enter Value", warning: "Wrong value!");
    int input = Input.NextInt(output: "Enter Value", warning: "Wrong value!");
    long input = Input.NextLong(output: "Enter Value", warning: "Wrong value!");
    sbyte input = Input.NextSByte(output: "Enter Value", warning: "Wrong value!");
    short input = Input.NextShort(output: "Enter Value", warning: "Wrong value!");
    uint input = Input.NextUInt(output: "Enter Value", warning: "Wrong value!");
    ulong input = Input.NextULong(output: "Enter Value", warning: "Wrong value!");
    ushort input = Input.NextUShort(output: "Enter Value", warning: "Wrong value!");
    
    // OR
    
    // All parameters are optional and have default values
    decimal input = Input.Next<decimal>(output: "Enter Value", warning: "Wrong value!");
    double input = Input.Next<double>(output: "Enter Value", warning: "Wrong value!");
    float input = Input.Next<float>(output: "Enter Value", warning: "Wrong value!");
    int input = Input.Next<int>(output: "Enter Value", warning: "Wrong value!");
    long input = Input.Next<long>(output: "Enter Value", warning: "Wrong value!");
    sbyte input = Input.Next<sbyte>(output: "Enter Value", warning: "Wrong value!");
    short input = Input.Next<short>(output: "Enter Value", warning: "Wrong value!");
    uint input = Input.Next<uint>(output: "Enter Value", warning: "Wrong value!");
    ulong input = Input.Next<ulong>(output: "Enter Value", warning: "Wrong value!");
    ushort input = Input.Next<ushort>(output: "Enter Value", warning: "Wrong value!");
}
```

### Do I plan on adding anything else?
```yaml
A of right now I have no idea on what else to create for this library. 
But if you'd like to contribute, or suggest features. 
Feel free to create a new issue!

[https://github.com/WaifuShork/SimpleInputs/issues]
```

### MIT License
<img alt="GitHub" src="https://img.shields.io/github/license/yiliansource/brackeys-bot">

Copyright (c) 2020 WaifuShork
```yaml
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:`

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

