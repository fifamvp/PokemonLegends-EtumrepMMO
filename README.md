# EtumrepMMO

The original repository: https://github.com/kwsch/EtumrepMMO

### Remark

**For players**

1. Go [.NET6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0), and download the latest .NET Desktop Runtime.
2. Download release zip file and unzip it.
3. Create a folder named `mons` and move ".pa8" files into it.
4. Execute **Run.bat** inside, which creates a folder in the directory named `previous` to backup the ".pa8" files from which the seed has been acquired.

> If Run.bat is executed by CMD, you can pass two parameters after it to represent the number of pokemons spawned in round 1 & 2. (e.g. `Run.bat 8 6`)
>
> The previous records are listed in `SeedRecords.txt` .



**For developer**

This solution requires building by Visual Studio 2022 with .Net 6.0 installed.

> According to this answer: https://stackoverflow.com/a/69989703, .NET 6 is only supported in Visual Studio 2022.
>
> References:
>
> https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version
>
> https://devblogs.microsoft.com/dotnet/announcing-net-6/







### Original Description

------

Reverses initial MMO data to find the origin (group) seed.

Requires [.NET 6.0](https://dotnet.microsoft.com/download/dotnet/6.0). The executable can be built with any compiler that supports C# 10.

Usage:
- Compile the ConsoleApp project, or obtain it from someone else.
- Put your 4 initial captures in a `mons` folder next to the executable.
- Run the executable, observe console output for matching seed.

Big thanks to Pokémon Automation ([@Mysticial](https://github.com/Mysticial)) for their [C++ implementation of Entity->Seed parallel brute-force](https://github.com/PokemonAutomation/Experimental/tree/4001b0402515ade042528d9bffb07ceab4476c96), which this repo uses (BSD license).

For more information, please refer to the wiki of [PermuteMMO](https://github.com/kwsch/PermuteMMO) as well as the wiki for this repo.
