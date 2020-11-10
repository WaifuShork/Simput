<h1 align="center" style="position: relative;">
    <img width="200" style="border-radius: 50%;" src="./simpleinputs.png"/><br>
    Simple Inputs Library
</h1>


[![Chat](https://img.shields.io/badge/chat-on%20discord-7289da.svg)](https://discord.com/invite/3qAtRfp) <img alt="Travis (.com)" src="https://img.shields.io/travis/com/yiliansource/brackeys-bot">

# Simple Inputs Library
This is a basic .NET Core Library for simple console inputs of all values, its basically a TryParse under the hood, handling all the tedius stuff for you!

This library brings a mix of how Python and Java handle inputs for non-string values. As of right now it only works with the console!


## Why bother with making this? 
I'm always making console apps so this is a must for me! Its must easier than constantly making TryParse statements, or even setting up a new method system for each project!

##  Documentation <img alt="GitHub" src="https://camo.githubusercontent.com/77e7cdcf1992654efde98939841b0312445f3e48/68747470733a2f2f696e63682d63692e6f72672f6173736574732f62616467652d6578616d706c652d62373166396538333333313866363666363462336632333837373131333035312e737667">

```c#
using SimpleInputs;

private static void Main()
{
    decimal input = NextDecimal("Enter decimal: ");
    double input = NextDouble("Enter double: ");
    float input = NextFloat("Enter float: ");
    int input = NextInt("Enter int: ");
    long input = NextLong("Enter long: ");
    sbyte input = NextSByte("Enter sbyte: ");
    short input = NextShort("Enter short: ");
    uint input = NextUInt("Enter uint: ");
    ulong input = NextULong("Enter ulong: ");
    ushort input = NextUShort("Enter ushort: ");
}
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

