This file is a merged representation of the entire codebase, combined into a single document by Repomix.

# File Summary

## Purpose
This file contains a packed representation of the entire repository's contents.
It is designed to be easily consumable by AI systems for analysis, code review,
or other automated processes.

## File Format
The content is organized as follows:
1. This summary section
2. Repository information
3. Directory structure
4. Repository files (if enabled)
5. Multiple file entries, each consisting of:
  a. A header with the file path (## File: path/to/file)
  b. The full contents of the file in a code block

## Usage Guidelines
- This file should be treated as read-only. Any changes should be made to the
  original repository files, not this packed version.
- When processing this file, use the file path to distinguish
  between different files in the repository.
- Be aware that this file may contain sensitive information. Handle it with
  the same level of security as you would the original repository.

## Notes
- Some files may have been excluded based on .gitignore rules and Repomix's configuration
- Binary files are not included in this packed representation. Please refer to the Repository Structure section for a complete list of file paths, including binary files
- Files matching patterns in .gitignore are excluded
- Files matching default ignore patterns are excluded
- Files are sorted by Git change count (files with more changes are at the bottom)

# Directory Structure
```
.gitignore
.repomixignore
Attachments/tutorials/prequisite-for-unit-test.xlsx
Attachments/tutorials/testing demo/Add-New-Project.png
Attachments/tutorials/testing demo/beaker.png
Attachments/tutorials/testing demo/Create-New-Project-CommandPalette-step2.png
Attachments/tutorials/testing demo/Create-New-Project-CommandPalette-step3.png
Attachments/tutorials/testing demo/Create-New-Project-CommandPalette-step4.png
Attachments/tutorials/testing demo/Create-New-Project-CommandPalette-step5.png
Attachments/tutorials/testing demo/Create-Solution-Or-Open-Solution.png
Attachments/tutorials/testing demo/DebugTestingManySolutions.png
Attachments/tutorials/testing demo/RunTesting.png
Attachments/tutorials/testing demo/RunTestingManySolutions.png
Attachments/tutorials/testing demo/Solution-icon.png
Directory.Packages.props
Example-Projects/Ex4/Ex4-8/Bad-Example/Bad-Example.csproj
Example-Projects/Ex4/Ex4-8/Bad-Example/MultipleActTasksInOneTestCaseExample.cs
Example-Projects/Ex4/Ex4-8/Calculator/Calculator.csproj
Example-Projects/Ex4/Ex4-8/Calculator/StringCalculator.cs
Example-Projects/Ex4/Ex4-8/Example-Project-4-8.slnx
Example-Projects/Ex4/Ex4-8/Good-Example/Good-Example.csproj
Example-Projects/Ex4/Ex4-8/Good-Example/SingleActTaskInOneTestCaseExample.cs
Example-Projects/Ex4/Ex4-8/Results/Errors/BadUnitTestExample#MultipleActTasksInOneTestCaseExample_PollutesTheGlobalProperty_ThusAssertionsMayNotBeExpected.png
Example-Projects/Ex4/Ex4-8/Results/Success/CorrectExample#SingleActTasksInOneTestCaseExample_NeverPollutesTheGlobalProperty_ThusAssertionsAreExpected.png
Example-Projects/Ex4/Ex4-9/Bad-Example/Bad-Example.csproj
Example-Projects/Ex4/Ex4-9/Bad-Example/TightCoupledClassTests.cs
Example-Projects/Ex4/Ex4-9/Calculator/Calculator.csproj
Example-Projects/Ex4/Ex4-9/Calculator/IDateTimeProvider.cs
Example-Projects/Ex4/Ex4-9/Calculator/LooseCoupledCalculator.cs
Example-Projects/Ex4/Ex4-9/Calculator/TightCoupledCalculator.cs
Example-Projects/Ex4/Ex4-9/Example-Project-4-9.slnx
Example-Projects/Ex4/Ex4-9/Good-Example/Good-Example.csproj
Example-Projects/Ex4/Ex4-9/Good-Example/LooseCoupledClassTests.cs
Example-Projects/Ex4/Ex4-9/Results/Errors/BadDesignPatternExample#GetDiscountedPrice_NotTuesday_ReturnsFullPrice#WhenInTuesday.png
Example-Projects/Ex4/Ex4-9/Results/Errors/description.md
Example-Projects/Ex4/Ex4-9/Results/Errors/message.md
Example-Projects/Ex4/Ex4-9/Results/Success/AllTestsPass.png
Example-Projects/Ex4/Ex4-9/Results/Success/message.md
Examples/Ex4/Bad-Ex4-1.cs
Examples/Ex4/Bad-Ex4-2.cs
Examples/Ex4/Bad-Ex4-3.cs
Examples/Ex4/Bad-Ex4-4.cs
Examples/Ex4/Bad-Ex4-5.cs
Examples/Ex4/Bad-Ex4-6.cs
Examples/Ex4/Bad-Ex4-7-2.cs
Examples/Ex4/Bad-Ex4-8-sematically-equivalence.cs
Examples/Ex4/Bad-Ex4-8.cs
Examples/Ex4/Good-Ex4-1.cs
Examples/Ex4/Good-Ex4-2.cs
Examples/Ex4/Good-Ex4-3.cs
Examples/Ex4/Good-Ex4-4.cs
Examples/Ex4/Good-Ex4-5.cs
Examples/Ex4/Good-Ex4-6.cs
Examples/Ex4/Good-Ex4-7-2.cs
Examples/Ex4/Good-Ex4-8.cs
LICENSE
README.md
repomix.config.json
tutorials/CH1 -- Introduction of unit test.md
tutorials/CH2 -- Installation.md
tutorials/CH3 -- Create a test project.md
tutorials/CH4 -- Best practices of Unit Test.md
tutorials/CH5 -- Test the test cases.md
tutorials/CH6 -- Test Platforms.md
tutorials/CH7 -- Test Frameworks.md
tutorials/CH8 -- Options of tests in .NET CLI.md
tutorials/CH9 -- Packages.md
```

# Files

## File: .repomixignore
````
# Add patterns to ignore here, one per line
# Example:
# *.log
# tmp/

# Obsidian cached folder
.obsidian
````

## File: repomix.config.json
````json
{
  "$schema": "https://repomix.com/schemas/latest/schema.json",
  "input": {
    "maxFileSize": 52428800
  },
  "output": {
    "filePath": "tutorial-of-Unit-Testing-repomix-output.md",
    "style": "markdown",
    "parsableStyle": false,
    "fileSummary": true,
    "directoryStructure": true,
    "files": true,
    "removeComments": false,
    "removeEmptyLines": false,
    "compress": false,
    "topFilesLength": 5,
    "showLineNumbers": false,
    "truncateBase64": false,
    "copyToClipboard": false,
    "includeFullDirectoryStructure": false,
    "tokenCountTree": false,
    "git": {
      "sortByChanges": true,
      "sortByChangesMaxCommits": 100,
      "includeDiffs": false,
      "includeLogs": false,
      "includeLogsCount": 50
    }
  },
  "include": [],
  "ignore": {
    "useGitignore": true,
    "useDotIgnore": true,
    "useDefaultPatterns": true,
    "customPatterns": []
  },
  "security": {
    "enableSecurityCheck": true
  },
  "tokenCount": {
    "encoding": "o200k_base"
  }
}
````

## File: tutorials/CH1 -- Introduction of unit test.md
````markdown
# CH1 -- Introduction of unit test
## objectives
You will learn what is unit test and why unit test is important.

## CH1-1 -- Introduction
Unit test is a technique that tests only the smallest unit (usually `one method) to 

check the logic is correct. And it behaves as you expected.

## CH1-2 -- Terminology
+ test case: A use case that will be tested.

+ use case: A scenario that will be shown when user uses this system (,or module etc).

## CH1-3 -- Features

Unit test has these features that other test does have:

+ Only test the smallest part to check one function works as you expected.

Unit test also has other features:

+ Can easily and quickly test to ensure one function or a series of functions will behave as you expected.

### CH1-4 -- Why it is important

According to [Features]() section,

we can derive these 

+ Saving time on test: Since one can easily and quickly test to ensure one function or 

a series of functions will behave as you expected instead of test manually (step-by-step)

+ Might find the potential bug:

After one writes more edge case for unit tests,

one can quickly check there is a bug in the edge cases.

It is impossible to check there is a bug in the edge cases by test it manually (step-by-step).
````

## File: tutorials/CH2 -- Installation.md
````markdown
# Prequisites
## Part 1: For developing environment (it can be installed once)

In `.NET`, we have to install these before writing unit tests 

(in fact, these are required once you write code with `.NET`)

About `.NET `environment

+ `.NET` SDK: for build and runtime

+ `.NET` SDK runtime: for runtime

+ `MSBuild`: for build and performing static analyzation etc

> [!NOTE]
> For more details about the excellent tool -- `MSBuild`, see [`MSBuild`]()

About templates

There are a few available templates that for unit tests.

+ `xUnit` (v.2)

+ `NUnit` (v.2)

+ `xUnit 3` (v.3)

We will discuss theses templates in the later article.


## Part 2: Reference these packages and SDKs
When one writes unit test on a project (let's called `IOOperationUtilityServices.Tests`),

then in the project, it needs to reference 

+ `Microsoft.NET.Test.Sdk`: the `.NET` SDK used for testing, so it is required for any framework. 

+ `coverlet.collector`

+ `xunit` (if you choose `xUnit 2` as framework)

+ `xunit.runner.visualstudio` (if you choose `xUnit 2` or `xUnit 3` as framework)

For summary, see [this sheet](..\Attachments\tutorials\prequisite-for-unit-test.xlsx)

## How to install?
### Using VSC as Code IDE
step 1:

download and install vsc from official site.

step 2:

install these vsc extensions from vsc marketplace

+ `C# Dev Kit`: a tool kit for `C#` development.

### Using VS as Code IDE
step 1:

download and install vs from official site.

step 2:

install components as framework

+ `.NET` SDK 

+ `.NET` SDK runtime

then installs the template you want to

### Using .NET SDK CLI
> [!WARNING]
> The newer command `dotnet new install` are only supported on .NET 7.0+
>
> If .NET SDK is on .NET 6.0 or below, you have to 
>
> use the oldest command `dotnet new` with `--install` long option.

#### `dotnet new install`
Simply use `dotnet new install` to install template or workloads.

Here, we just pass the test template as the argument value 

Syntax:

```
dotnet new install <package_ID>
```

where

`<Package_ID>` : id of package (including template or workload) you want to install

| `<Package_ID>`                | template to be installed |
| :---------------------------- | :----------------------- |
| `xunit.templates`             | `xUnit 2`                |
| `xunit.v3.templates`          | `xUnit 3`                |
| `NUnit3.DotNetNew.Template`   | `NUnit`                  |
| `Microsoft.DotNet.TestLogger` | `MSTest`                 |
````

## File: tutorials/CH3 -- Create a test project.md
````markdown
# CH3 -- Create a test project
## objectives
In this article, you will know how to

+ create a test project

## CH3-1 -- Create a test project
> [!WARNING]
> Before creating a test project, you must ensure the templates for testing are installed 
> 
> and not corrupted.

### Using VS
Step 1:

Go to `New project` dialog.

To do so,

(If in existing solution) In solution explorer, 

select the solution, then right-click, select `add new project`

(If the solution does not exist) Please VS. Then select `Create new Solution`.

Step 2:

In `New project` dialog, select the template you want to use.

Step 3:

Type the name of the new project.

### Using VSC
> [!WARNING]
> Before creating a test project, you must ensure `C# Dev Kit` VSC extension is installed and 
>
> not corrupted.

Step 1:

Open VSC workspace (by opening folder).

Next, go to solution panel [By click the Solution icon](..\Attachments\tutorials\testing%20demo\Solution-icon.png)

Step 2:

If it detects there is no any solutions that is directly child of the root of workspace, 

that indicates you don't create a solution successfully.

Thus, you have to create a solution or open the solution on [solution panel](..\Attachments\tutorials\testing%20demo\Create-Solution-Or-Open-Solution.png)

Otherwise, do nothing, skip to step 3.

Step 3:

On solution panel,

right click the solution, 

select [`Add new project` icon](..\Attachments\tutorials\testing%20demo\Add-New-Project.png)

Step 4:

Follow its instruction to fill them into `Command Palette`.

Following figures illustrate which data you need to enter respectively.

[Add new project (2/5)](..\Attachments\tutorials\testing%20demo\Create-New-Project-CommandPalette-step2.png)

[Add new project (3/5)](..\Attachments\tutorials\testing%20demo\Create-New-Project-CommandPalette-step3.png)

[Add new project (4/5)](..\Attachments\tutorials\testing%20demo\Create-New-Project-CommandPalette-step4.png)

[Add new project (5/5)](..\Attachments\tutorials\testing%20demo\Create-New-Project-CommandPalette-step5.png)

### Using `.NET` SDK CLI
Simply use `dotnet new` command

Syntax:

```
dotnet new <Template_Short_Name>
```

where

`<Template_Short_Name>` : short name of templated used as test framework you want to create

| `<Template-Short-Name>` | test framework will be used |
| :-- | :-- |
| `xunit` | `xUnit 2` (xUnit 2 Test Project) |
| `xunit3` | `xUnit 3` (xUnit.net v3 Test Project) |
| `nunit` | `NUnit` (NUnit Test Project) | 
| `mstest` | `MSTest` (MSTest Test Project) |
| `mstest-class` | `MSTest` (MSTest Test Class) |
| `mstest-playwright` | `MSTest Playwright` (MSTest Playwright Test Project) |
| `xunit3-extension` | `xUnit Extension` (xUnit.net v3 Extension Project) |
| `nunit-test` | `NUnit item` (NUnit Test Item) |
| `nunit-playwright` | `NUnit Playwright` (NUnit Playwright Test Project ) |

> [!TIP]
> To list all available templates for testing on your environment,
>
> simply execute this command in terminal
>
> ```
> dotnet new list --tag Test
> ```
````

## File: tutorials/CH5 -- Test the test cases.md
````markdown
# CH5 -- Test the test cases
## objectives
In this article, you will learn how to

    + test these test cases.

    + look at test result

## CH5-1 -- Test the test cases
### prequisites

It might leave the old status or result after you change codes

especially in the scenario one tests them on `Testing` panel which using `C# Dev Kit` VSC extension.

To clear old status, before testing, it is highly recommend to following these steps.

Step 1:

Close current VSC instance (if not closed yet).

Step 2: 

Physically delete the bin, obj folder and artifacts of this solution etc (as the old status stored in a file 

under the obj folder for performance, while, `C# Dev Kit` VSC extension fetches 

the available assemblies `*.dll` that are restored under bin folder) 

Step 3:

Clean the solution

Executing `dotnet clean`.

Step 4:

Build the solution again

Executing `dotnet build`

### Using VS
Step 1:

Open test explorer

It can be done by 

+ in menu bar, select `Test`  -> `Test explorer`, or

+ in solution explorer, right click the project that you want to test.

Then select `Test Explorer`.

Step 2:

Click the item you want to test.

> [!NOTE]
> Please check the item is selected (its background color is different than other if selected)
>
> after one selected it.


Step 3:

If you want to directly run the test, please click the run button

If you want to use debugger to debug the test, please click the debugger button

### Using VSC

Similarly, one can test test cases in Test explorer in VSC

Step 1:

Open test explorer

It can be done by

+ in the left-side bar, select `Testing` panel (its icon looks like a [beaker](..\Attachments\tutorials\testing%20demo\beaker.png))

Step 2:

Click the item you want to test.

> [!NOTE]
> Please check the item is selected (its background color is different than other if selected)
>
> after one selected it.

Step 3:

If you want to directly run the test, please click the run button

If you want to use debugger to debug the test, please click the debugger button

### Using `dotnet` CLI
Step 1:

Think about which tests need to be tested.

Step 2:

Open terminal

Step 3:

Change the directory (if you don't want to specify current working directory as arguments of `dotnet test`)

If you want to test all test cases of solution, please change the current working directory to
 
solution root (the parent of solution file `*.sln` or `*.slnx`)

If you want to test all test cases of project, please change the current working directory to
 
the project root (the parent of project file `*.csproj`)

> [!NOTE]
> The reason why it works due to the recursive search (from top to down) feature of `msbuild` 
>
> For more details, see [`msbuild`]() (if I have time to write articles)

Step 4:

Executing `dotnet test` and wait...

Then you look at output of command terminal.

> [!NOTE]
> If one doesn't specify the path, it will use defaults -- current working directory.
> 
> Let's why I said we need to current working directory if path is not specified.

### Examples
#### Example 1
If you want to test all test cases under `DriveInfoUtilityServicesTests` class,

then you have to click `DriveInfoUtilityServicesTests` on testing panel (illustrated as below image).

Then click the run button.

![RunTesting.png](../Attachments/tutorials/testing%20demo/RunTesting.png)


#### Example 2
If you want to test all test cases under `D:\workspace\utility_packages` directory 

(assuming that the container path of the MonoRepo is `D:\workspace\utility_packages`, please replace with your actual)

then you have to click the most top of run button on testing panel (illustrated as below image).

Then click the run button.

![RunTestingManySolutions](../Attachments/tutorials/testing%20demo/RunTestingManySolutions.png)


#### Example 3
If you want to debug all test cases under `D:\workspace\utility_packages` directory 

(assuming that the container path of the MonoRepo is `D:\workspace\utility_packages`, please replace with your actual)

then you have to click the most top of run button on testing panel (illustrated as below image).

Then click the run button.

![DebugTestingManySolutions](../Attachments/tutorials/testing%20demo/DebugTestingManySolutions.png)

## CH5-2 -- Look at results of test cases and Quickly locates exceptions.
### Using VS
In VS (or VSC), after the test cases are completed,

you will see each item is marked with **red X** icon or **green check** icon

where 

**red X** icon means the test case fails.

**green check** icon means the test success.

You can double-click the item with left mouse, then it is redirect to where throws the exception.  

You can look at the exception stack trace (if not catched by test framework) and 

give the full exception stack trace and its related files to 

ask AI Agent.

> [!WARNING]
> If one writes the assertion using test framework instead of `FluentAssertion` package,
>
> The exception stack trace will be thrown, see [CH9-1](../CH9-1) for more details.

> [!TIP]
> For more convention (and saving time), 
> 
> you can use packing tool (such as `repomix`)

> [!TIP]
> For more easily development, 
> 
> you can create customized Gems (if you want to use `Gemini`), then ask it.
>
> Even you can use built-in AI Agent in IDE (if it supports or there exists a extension)

### using VSC
Similarly, it is applied to test cases in `VSC`.

### Using `dotnet` CLI
#### Use `dotnet test`
If all tested test cases success, then you will don't see any red text in the output.

Otherwise (or there are build errors), 

then you will see the text like `errors: x` with red color at the last line of output.

> [!WARNING]
> If one writes the assertion using test framework instead of `FluentAssertion` package,
>
> The exception stack trace will be thrown, see [CH9-1 -- About assertions](../CH9-1%20--%20About%20assertions)
>  for more details.

#### Use `dotnet run`
You can simply run the test project to test the whole test cases defined in the project.

#### Use `dotnet exec`
You can also execute the assembly file `*.dll`

> [!NOTE]
> For more details, vist the page of links given in `References` section

## References
+ [Run and debug tests](https://learn.microsoft.com/en-us/dotnet/core/testing/microsoft-testing-platform-run-and-debug?tabs=dotnetcli)
````

## File: tutorials/CH6 -- Test Platforms.md
````markdown
# CH6 -- Test Frameworks
## objectives
In this article, you will learn these frameworks.


## CH6-1 -- Available test platform
There are two testing platforms in `.NET`

+ VSTest (stands for `Visual Studio Test Platform`) (old, but can't be replaced)

+ MTP (stands for `Microsoft Testing Platform`) (newer, but can't replace `VSTest`) 

### `VSTest`
#### Features
+ Pros:

    - Backward-compatibility:

    It supports NOT ONLY on older framework (e.g. `.NET` Framework 3.2) 

    BUT ALSO on the test cases written in other programming language which are NOT supported on 

    `.NET` ecosystem (e.g. for `C++`)
    
+ Cons:

    - Non-lightweight: its test runner combined with a console, exactly to say,

    It is behind a `console.exe` 

### `MTP`
#### Features
+ Pros:

    - A lightweighted testing platform since it is standalone, not combined with console.

    - Fast: as it is lightweighted.

+ Cons:

    - It only supports on newer framework (and newer architeture), and on `.NET` ecosystem.
````

## File: tutorials/CH7 -- Test Frameworks.md
````markdown
# CH7 -- Test Frameworks
## objectives
In this article, you will learn these frameworks.


## CH7-1 -- Available test 
There are three main testing framework in `.NET`

+ MSTest

+ NUnit

+ xUnit

### `MSTest` (old, obsolete)
#### Features
+ Pros:

    The only pros is

    - One needs to integrated with Microsoft Product (Enterprise) without any tool or plugin etc 
    
    since it is developed by Microsoft itself and its main purpose is easily integrated to 
    
    Microsoft Product (Enterprise)

+ Cons:

    - No isolation, all test cases in one class shares same instance.

### `NUnit`
#### Features
+ Cons:

    - No isolation, all test cases in one class shares same instance.

### `xUnit 2`
#### Features
+ Pros:

    - Isolation: all tests case are independent.

    - Stability: relative to `xUnit 3`

+ Cons:

    - Slower performance: although it is usually faster than `MSTest` and `NUnit`, it is slower than `xUnit 3`

### `xUnit 3`
+ Pros:

    - Better performance: it is much faster than `xUnit v2`

+ Cons:

    - Stability: although it is more stable than `MSTest` (as the developer team of `.NET`
    
     community determines to make a wheel from `MSTest` and then refactor it ),
     
     it is less stable than `xUnit 2` (as it is recently developed, not used by many people) 

## References

+ [Gems Response](https://gemini.google.com/share/4468377c3a4a)

+ [Gems Response](https://gemini.google.com/share/50147cdae6ef)
````

## File: tutorials/CH8 -- Options of tests in .NET CLI.md
````markdown
# CH7 -- Options of tests in .NET CLI
## objectives
In this article, you will learn 

    + the options of `dotnet test`

## CH7-1 -- terminology
+ Response file:

A file containing options which its contents will be inline-replaced when it is specified.

+ Platform options:

Platform options let you to specify response file (`*.rsp`)

## CH7-2 -- Response file
+ Pros:

    - High Reusability: Let one don't need to write the whole options in every test.

    - Bypass the terminal max token limits since 
    
    one doesn't need to write the whole options in command line (it is written in file)

## References
+ [What is response file? (Gems Response)](https://gemini.google.com/share/f3ad58838576)

+ [Microsoft.Testing.Platform (MTP) CLI options reference](https://learn.microsoft.com/en-us/dotnet/core/testing/microsoft-testing-platform-cli-options)
````

## File: tutorials/CH9 -- Packages.md
````markdown
# CH9 -- Packages
## objectives
In this article, you will know

+ commonly used packages for writing unit test

## CH9-1 -- About assertions
The test framework (published by Microsoft) supports assertions.

However, they are not fluent and 

catch the exception stack trace, 

so that if one tests on IDE, 

then one won't see the exception stack trace or exception stack trace is not conspicuous.

To resolve these disadvantages, 

simply install packages `FluentAssertions`

### `FluentAssertions`

`FluentAssertions` makes you write assertion fluently, as write a sentence in English.

For example:

With `FluentAssertions`, you can simply write

```
var actualValue = 2;
actualValue.Should().Be(expectedValue);
```

While without `FluentAssertions`, you may need to write

```
var actualValue = 2;
Assert.Equal(actualValue,expectedValue);
```

which makes it hard to read.

## CH9-2 -- About mocking
To mock the object, you can simply use an excellent package `Moq`.

> [!WARNING]
> `Moq` can only mock `interfaces` and non-static `virtual` methods
>
> If you want to mock the extension methods, it will be troublesome.
>
> See [`Moq`]() for more details.
````

## File: .gitignore
````
## A streamlined .gitignore for modern .NET projects
## including temporary files, build results, and
## files generated by popular .NET tools. If you are
## developing with Visual Studio, the VS .gitignore
## https://github.com/github/gitignore/blob/main/VisualStudio.gitignore
## has more thorough IDE-specific entries.
##
## Get latest from https://github.com/github/gitignore/blob/main/Dotnet.gitignore

# Build results
[Dd]ebug/
[Dd]ebugPublic/
[Rr]elease/
[Rr]eleases/
x64/
x86/
[Ww][Ii][Nn]32/
[Aa][Rr][Mm]/
[Aa][Rr][Mm]64/
bld/
[Bb]in/
[Oo]bj/
[Ll]og/
[Ll]ogs/

# .NET Core
project.lock.json
project.fragment.lock.json
artifacts/

# ASP.NET Scaffolding
ScaffoldingReadMe.txt

# NuGet Packages
*.nupkg
# NuGet Symbol Packages
*.snupkg

# dotenv environment variables file
.env

# Others
~$*
*~
CodeCoverage/

# MSBuild Binary and Structured Log
*.binlog

# MSTest test Results
[Tt]est[Rr]esult*/
[Bb]uild[Ll]og.*

# NUnit
*.VisualState.xml
TestResult.xml
nunit-*.xml
````

## File: Directory.Packages.props
````
<Project>
	<PropertyGroup>
	  <NoWarn>$(NoWarn);NU1507</NoWarn>
	</PropertyGroup>
  <PropertyGroup>
    <ManagePackageVersionsCentrally>true</ManagePackageVersionsCentrally>
    <CentralPackageTransitivePinningEnabled>true</CentralPackageTransitivePinningEnabled>
  </PropertyGroup>
  <!-- If one didn't specify the package version, treat it as errors instead of warnings -->
  <PropertyGroup>
    <WarningsAsErrors>$(WarningsAsErrors);NU1008;NU1605</WarningsAsErrors>
  </PropertyGroup>
  <!-- Let projetcs can be compiled in .NET Framework (older version) when not installed -->
  <ItemGroup>
    <GlobalPackageVersion Include="NETStandard.Library" Version="2.0.3" PrivateAssets="all" IncludeAssets="runtime; build; native; contentfiles; analyzers; buildtransitive"/>
  </ItemGroup>
  <ItemGroup>
    <!-- This applies to ALL projects in the repository automatically -->
    <GlobalPackageVersion Include="Microsoft.NETFramework.ReferenceAssemblies" Version="1.0.3" PrivateAssets="all" IncludeAssets="runtime; build; native; contentfiles; analyzers; buildtransitive" />
  </ItemGroup>
  <!-- When uses `.NET Test Framework`, `Microsoft.NET.Test.Sdk` is used, but for older framework, uses the older version of `Microsoft.NET.Test.Sdk`  -->
  <!--
  <ItemGroup Condition="'$(IsLegacyFramework)' != 'true' And '$(TargetFramework)' != 'net452' And '$(TargetFramework)' != 'net472' And '$(TargetFramework)' != 'netstandard2.0'">
    <PackageVersion Include="Microsoft.NET.Test.Sdk" Version="17.14.1" />
  </ItemGroup>
  <ItemGroup Condition="'$(IsLegacyFramework)' == 'true' Or '$(TargetFramework)' == 'net8.0' Or '$(TargetFramework)' == 'net452' Or '$(TargetFramework)' == 'net472' Or '$(TargetFramework)' == 'netstandard2.0'">
    <PackageVersion Include="Microsoft.NET.Test.Sdk" Version="17.14.1" />
  </ItemGroup>
  -->
  <ItemGroup>
    <PackageVersion Include="Microsoft.NET.Test.Sdk" Version="17.14.1" />
  </ItemGroup>
  <!-- Use .ASP .NET Core Framework -->
  <ItemGroup>
    <PackageVersion Include="Microsoft.AspNetCore.App.Ref" Version="10.0.5" />
  </ItemGroup>
  <ItemGroup>
    <PackageVersion Include="Microsoft.TeamFoundationServer.ExtendedClient" Version="20.256.2" />
  </ItemGroup>
  <!-- Mock File System -->
  <ItemGroup Condition="'$(IsLegacyFramework)' != 'true' And '$(TargetFramework)' != 'net452' And '$(TargetFramework)' != 'net472' And '$(TargetFramework)' != 'netstandard2.0'">
    <!-- abstraction of File system -->
    <PackageVersion Include="System.IO.Abstractions" Version="22.1.1" />
    <!-- Mock File System -->
    <PackageVersion Include="System.IO.Abstractions.TestingHelpers" Version="22.1.1" />
  </ItemGroup>
  <ItemGroup Condition="'$(IsLegacyFramework)' == 'true' Or '$(TargetFramework)' == 'net8.0' Or '$(TargetFramework)' == 'net452' Or '$(TargetFramework)' == 'net472' Or '$(TargetFramework)' == 'netstandard2.0'">    <!-- abstraction of File system -->
    <PackageVersion Include="System.IO.Abstractions" Version="19.2.87" />
    <!-- Mock File System -->
    <PackageVersion Include="System.IO.Abstractions.TestingHelpers" Version="19.2.87" />
  </ItemGroup>
  <!-- abstraction of System Process -->
  <ItemGroup>
    <PackageVersion Include="System.Diagnostics.Abstractions" Version="1.0.9" />
  </ItemGroup>
  <!-- abstraction of System Process (used by older test framework such as `xUnit2`) -->
  <ItemGroup>
    <PackageVersion Include="Testably.Abstractions.FileSystem.Interface" Version="10.2.0" />
  </ItemGroup>
  <!-- Official utility packages of command line -->
  <ItemGroup>
    <PackageVersion Include="System.CommandLine" Version="2.0.5" />
  </ItemGroup>
  <!-- .NET SDK used by test framework -->
  <ItemGroup>
    <PackageVersion Include="Microsoft.NET.Test.Sdk" Version="17.14.1" />
  </ItemGroup>
  <!-- `MSBuild`, simulating `MSBuild` behaviour -->
  <ItemGroup>
    <PackageVersion Include="Microsoft.Build" Version="18.4.0" />
  </ItemGroup>
  <!-- Locator of `MSBuild` -->
  <ItemGroup>
    <PackageVersion Include="Microsoft.Build.Locator" Version="1.11.2" />
  </ItemGroup>
  <!-- Official utility packages about accessing version of NuGet package or .NET framework -->
  <ItemGroup>
    <!-- accessing version of  NuGet package -->
    <PackageVersion Include="NuGet.Protocol" Version="7.3.1" />
    <!-- accessing version of  .NET framework -->
    <PackageVersion Include="NuGet.Frameworks" Version="7.3.1" />
  </ItemGroup>
  <!-- Use traditional mode `VSTest` -->
  <!-- `NUnit` as Test Framework -->
  <ItemGroup>
    <PackageVersion Include="NUnit" Version="4.3.2" />
    <PackageVersion Include="NUnit3TestAdapter" Version="6.2.0" />
    <PackageVersion Include="NUnit.Analyzers" Version="4.7.0" />
  </ItemGroup>
  <!-- `xUnit.v3` as Test Framework -->
  <ItemGroup>
    <PackageVersion Include="coverlet.collector" Version="6.0.4" />
    <PackageVersion Include="xunit.v3" Version="3.2.2" />
    <PackageVersion Include="xunit.v3.mtp-v2" Version="3.2.2" />
    <PackageVersion Include="xunit.v3.extensibility.core" Version="3.2.2" />
  </ItemGroup>
  <!-- package that checks the class or property contains specific words, it uses `xUnit.v2` as Test Framework -->
  <ItemGroup>
    <PackageVersion Include="TngTech.ArchUnitNET.xUnit" Version="0.13.3" />
  </ItemGroup>
  <!-- `xUnit.v2` as Test Framework -->
  <ItemGroup>
    <PackageVersion Include="xunit" Version="2.9.3" />
    <PackageVersion Include="xunit.runner.visualstudio" Version="3.1.4" />
  </ItemGroup>
  <!-- Use modern mode `MTP` -->
  <!-- use `MSTest` as Test Framework -->
  <ItemGroup>
    <PackageVersion Include="MSTest.TestAdapter" Version="3.2.2" />
    <PackageVersion Include="MSTest.TestFramework" Version="3.2.2" />
    <PackageVersion Include="Microsoft.Testing.Extensions.VSTestBridge" Version="2.1.0" />
  </ItemGroup>
  <!-- use `NUnit` using `MTP` as Test Framework -->
  <ItemGroup>
    <PackageVersion Include="Microsoft.TestPlatform" Version="18.4.0" />
    <PackageVersion Include="Microsoft.Testing.Platform.MSBuild" Version="2.2.1" />
  </ItemGroup>
  <ItemGroup>
    <PackageVersion Include="Microsoft.Testing.Platform" Version="2.2.1" />
  </ItemGroup>
  <!-- packages that makes the assertions be more fluent -->
  <ItemGroup Condition="'$(IsLegacyFramework)' != 'true' And '$(TargetFramework)' != 'net452' And '$(TargetFramework)' != 'net472' And '$(TargetFramework)' != 'netstandard2.0'">
    <PackageVersion Include="FluentAssertions" Version="8.9.0" />
    <PackageVersion Include="FluentValidation" Version="12.1.1" />
  </ItemGroup>
  <ItemGroup Condition="'$(IsLegacyFramework)' == 'true' Or '$(TargetFramework)' == 'net8.0' Or '$(TargetFramework)' == 'net452' Or '$(TargetFramework)' == 'net472' Or '$(TargetFramework)' == 'netstandard2.0'">
    <PackageVersion Include="FluentAssertions" Version="5.10.3" />
    <PackageVersion Include="FluentValidation" Version="8.6.3" />
  </ItemGroup>
  <!-- packages that mock the interface and virtual class -->
  <ItemGroup>
    <PackageVersion Include="Moq" Version="4.20.72" />
  </ItemGroup>
  <!-- packages that checks the AST of class (including, check a class contains property named `property1`) -->
  <ItemGroup>
    <PackageVersion Include="NSubstitute" Version="5.3.0" />
  </ItemGroup>
  <!-- Rolsyn -->
  <ItemGroup>
    <PackageVersion Include="Microsoft.CodeAnalysis.CSharp" Version="5.3.0" />
    <PackageVersion Include="Microsoft.CodeAnalysis.CSharp.Workspaces" Version="5.3.0" />
  </ItemGroup>
  <!-- Rolsyn used for tests -->
  <ItemGroup>
    <PackageVersion Include="Microsoft.CodeAnalysis.CSharp.SourceGenerators.Testing" Version="1.1.3" />
  </ItemGroup>
  <!-- Roslynator -->
  <ItemGroup>
    <PackageVersion Include="Roslynator.Analyzers" Version="4.15.0"/>
  </ItemGroup>
  <!-- SonarAnalyzer -->
  <ItemGroup>
    <PackageVersion Include="SonarAnalyzer.CSharp" Version="10.25.0.139117" />
  </ItemGroup>
  <ItemGroup>
    <PackageVersion Include="Microsoft.Bcl.AsyncInterfaces" Version="10.0.7" />
    <PackageVersion Include="System.ClientModel" Version="1.10.0" />
    <PackageVersion Include="System.Memory.Data" Version="10.0.3" />
  </ItemGroup>
   <!-- logger `ILogger` -->
  <Choose>
    <When Condition="'$(IsAtLeast8)' == 'true'">
      <ItemGroup>
        <PackageVersion Include="Microsoft.Extensions.Logging" Version="[11.0.0-preview.2.26159.112]" />
        <PackageVersion Include="Microsoft.Extensions.Logging.Abstractions" Version="[11.0.0-preview.2.26159.112]" />
        <PackageVersion Include="Microsoft.Extensions.Options" Version="[11.0.0-preview.2.26159.112]" />
        <PackageVersion Include="Microsoft.Extensions.DependencyInjection" Version="[11.0.0-preview.2.26159.112]" />
        <PackageVersion Include="Microsoft.Extensions.DependencyInjection.Abstractions" Version="[11.0.0-preview.2.26159.112]" />
        <PackageVersion Include="Microsoft.Extensions.Configuration.Abstractions" Version="[11.0.0-preview.2.26159.112]" />
        <PackageVersion Include="Microsoft.Extensions.Primitives" Version="[11.0.0-preview.2.26159.112]" />
        <PackageVersion Include="Microsoft.Extensions.Hosting" Version="10.0.3" />
        <PackageVersion Include="Microsoft.Extensions.Hosting.Abstractions" Version="10.0.3" />
      </ItemGroup>
    </When>
    <When Condition="'$(IsAtLeast6)' == 'true' And '$(IsAtLeast8)' != 'true' ">
      <ItemGroup>
          <PackageVersion Include="Microsoft.Extensions.Logging" Version="10.0.3" />
          <PackageVersion Include="Microsoft.Extensions.Logging.Abstractions" Version="10.0.3" />
          <PackageVersion Include="Microsoft.Extensions.Options" Version="10.0.3" />
          <PackageVersion Include="Microsoft.Extensions.DependencyInjection" Version="10.0.3" />
          <PackageVersion Include="Microsoft.Extensions.DependencyInjection.Abstractions" Version="10.0.3" />
          <PackageVersion Include="Microsoft.Extensions.Configuration.Abstractions" Version="10.0.3" />
          <PackageVersion Include="Microsoft.Extensions.Primitives" Version="10.0.3" />
          <PackageVersion Include="Microsoft.Extensions.Hosting" Version="10.0.3" />
          <PackageVersion Include="Microsoft.Extensions.Hosting.Abstractions" Version="10.0.3" />
      </ItemGroup>
    </When>
    <Otherwise>
      <ItemGroup>
      <!-- NOT specify version of `Microsoft.Extensions.Logging` and its related packages as it is NOT supported -->
          <PackageVersion Include="Microsoft.Extensions.Logging" Version="10.0.3" />
          <PackageVersion Include="Microsoft.Extensions.Logging.Abstractions" Version="10.0.3" />
          <PackageVersion Include="Microsoft.Extensions.Options" Version="10.0.3" />
          <PackageVersion Include="Microsoft.Extensions.DependencyInjection" Version="10.0.3" />
          <PackageVersion Include="Microsoft.Extensions.DependencyInjection.Abstractions" Version="10.0.3" />
          <PackageVersion Include="Microsoft.Extensions.Configuration.Abstractions" Version="10.0.3" />
          <PackageVersion Include="Microsoft.Extensions.Primitives" Version="10.0.3" />
          <PackageVersion Include="Microsoft.Extensions.Hosting" Version="10.0.3" />
          <PackageVersion Include="Microsoft.Extensions.Hosting.Abstractions" Version="10.0.3" />
        </ItemGroup>
    </Otherwise>
  </Choose>
   <!-- Azure -->
  <ItemGroup>
    <PackageVersion Include="Azure.ResourceManager" Version="1.14.0" />
    <PackageVersion Include="Azure.Identity" Version="1.18.0" />
    <PackageVersion Include="Azure.Core" Version="1.51.1" />
    <PackageVersion Include="Microsoft.Extensions.Configuration" Version="10.0.3" />
    <PackageVersion Include="Microsoft.Extensions.Configuration.AzureAppConfiguration" Version="8.5.0" />
  </ItemGroup>
  <!--  -->
  <ItemGroup>
    <PackageVersion Include="System.Management" Version="10.0.2" />
  </ItemGroup>
  <!-- Registry key on Windows OS -->
  <ItemGroup>
    <PackageVersion Include="Microsoft.Win32.Registry" Version="5.0.0" />
  </ItemGroup>
  <!-- ACL on Windows OS -->
  <ItemGroup>
    <PackageVersion Include="System.Security.AccessControl" Version="6.0.1" />
  </ItemGroup>
  <!-- lock -->
  <ItemGroup>
    <PackageVersion Include="AsyncKeyedLock" Version="8.0.2" />
  </ItemGroup>
  <!-- EF Core -->
  <ItemGroup>
    <PackageVersion Include="Microsoft.EntityFrameworkCore" Version="10.0.3" />
  </ItemGroup>
  <ItemGroup>
    <PackageVersion Include="StackExchange.Redis" Version="2.11.0" />
  </ItemGroup>
  <!-- `Serilog` -->
  <ItemGroup>
    <PackageVersion Include="Serilog" Version="4.3.1" />
    <PackageVersion Include="Serilog.Settings.Configuration" Version="10.0.0" />
    <PackageVersion Include="Serilog.Enrichers.Environment" Version="3.0.1" />
    <PackageVersion Include="Serilog.Exceptions" Version="8.4.0" />
    <PackageVersion Include="Serilog.Enrichers.Demystifier" Version="1.0.3" />
    <PackageVersion Include="Serilog.Expressions" Version="5.0.0" />
    <PackageVersion Include="Serilog.Sinks.File" Version="7.0.0" />
    <PackageVersion Include="Serilog.Sinks.Console" Version="6.1.1" />
    <PackageVersion Include="Serilog.Extensions.Hosting" Version="10.0.0" />
    <PackageVersion Include="Serilog.Extensions.Logging" Version="10.0.0" />
  </ItemGroup>
  <!-- `Nuke` -->
  <ItemGroup>
    <PackageVersion Include="Nuke.Common" Version="10.1.0" />
  </ItemGroup>
  <!-- `PostSharp` -->
  <ItemGroup>
    <PackageVersion Include="PostSharp" Version="2026.0.6" />
    <PackageVersion Include="PostSharp.Patterns.Diagnostics" Version="2026.0.6" />
  </ItemGroup>
  <!-- `Appium.WebDriver` -->
  <ItemGroup>
    <PackageVersion Include="Appium.WebDriver" Version="8.1.0" />
    <PackageVersion Include="Selenium.WebDriver" Version="4.36.0" />
  </ItemGroup>
  <!-- `Polly` -->
  <ItemGroup>
    <PackageVersion Include="Polly" Version="8.6.6" />
    <PackageVersion Include="Polly.Core" Version="8.6.6" />
    <PackageVersion Include="Polly.RateLimiting" Version="8.6.6" />
    <PackageVersion Include="Polly.Extensions" Version="8.6.6" />
  </ItemGroup>
  <!-- other packages -->
  <ItemGroup>
    <PackageVersion Include="MiniExcel" Version="2.0.0-preview.2" />
    <PackageVersion Include="QRCoder" Version="1.7.0" />
    <PackageVersion Include="Otp.NET" Version="1.4.1" />
    <PackageVersion Include="Spectre.Console" Version="0.54.0" />
    <PackageVersion Include="MediatR" Version="14.0.0" />
  </ItemGroup>
  <!-- about command line (CLI)  -->
  <ItemGroup>
    <PackageVersion Include="CliWrap" Version="3.10.1" />
  </ItemGroup>
   <!-- about encoding -->
  <ItemGroup>
    <PackageVersion Include="System.Text.Encoding.CodePages" Version="10.0.7" />
  </ItemGroup>
  <!-- about sanitization -->
  <ItemGroup>
    <PackageVersion Include="System.Text.Encodings.Web" Version="10.0.7" />
  </ItemGroup>
  <!-- about file system globbing -->
  <ItemGroup>
    <PackageVersion Include="Microsoft.Extensions.FileSystemGlobbing" Version="10.0.7" />
  </ItemGroup>
  <!-- F# compiler and F# core library -->
  <ItemGroup>
    <PackageVersion Include="FSharp.Compiler.Service" Version="43.12.203" />
    <PackageVersion Include="FSharp.Core" Version="10.1.203" />
  </ItemGroup>
  <!-- My developed NuGet packages -->
  <ItemGroup>
    <PackageVersion Include="AiUtility.AiBaseUtilityServices" Version="[3.0.0-preview-1.0.0]" />
    <PackageVersion Include="AiUtility.ToolKits" Version="[3.0.0-preview-1.0.0]" />
    <PackageVersion Include="AiUtility.GeminiKits" Version="[3.0.0-preview-1.0.0]" />
    <PackageVersion Include="AiUtility.GeminiUtilityServices" Version="[3.0.0-preview-1.0.0]" />
  </ItemGroup>
  <!-- My developed NuGet packages -->
  <ItemGroup>
    <PackageVersion Include="EnumUtilityServices" Version="2.0.0" />
    <PackageVersion Include="CustomDataAnnotations" Version="2.4.0" />
    <PackageVersion Include="TypeConstants" Version="2.1.0" />
    <PackageVersion Include="MimeTypeConstants" Version="3.0.0" />
  </ItemGroup>
  <!-- My developed NuGet packages -->
  <ItemGroup>
    <PackageVersion Include="ExpressionTreeUtilityServices" Version="2.0.0" />
    <PackageVersion Include="ReflectionUtilityServices" Version="2.0.0" />
    <PackageVersion Include="LogNameUtilityFactories" Version="[2.0.0-preview-1.0.0]" />
    <PackageVersion Include="RegexUtilityServices" Version="2.0.0" />
    <PackageVersion Include="AssemblyUtilityServices" Version="[2.0.0-preview-1.0.0]" />
    <PackageVersion Include="ExceptionHandlingUtilityServices" Version="[3.0.0-preview-1.0.0]" />
    <PackageVersion Include="ExceptionFactories" Version="2.0.0" />
    <PackageVersion Include="ExceptionWrappers" Version="[3.0.0-preview-1.0.0]" />
    <PackageVersion Include="FileStreamUtilityServices" Version="2.1.0" />
    <PackageVersion Include="JsonUtilityServices" Version="2.0.0" />
    <PackageVersion Include="LoggerFactoryUtilityServices" Version="[5.0.0-preview-1.0.0]" />
    <PackageVersion Include="TaskUtilityServices" Version="2.0.0" />
    <PackageVersion Include="ThreadLevelLockingUtilityServices" Version="[2.0.0-preview-1.0.0]" />
    <PackageVersion Include="TypeUtilityServices" Version="2.0.0" />
    <PackageVersion Include="SerilogHelperServices" Version="2.0.0" />
    <PackageVersion Include="CoordinateUtilityServices" Version="2.0.0" />
    <PackageVersion Include="TransversalUtilityServices" Version="[2.0.0-preview-1.0.0]" />
    <PackageVersion Include="AzureUtilityServices" Version="[2.0.0-preview-1.0.0]" />
    <PackageVersion Include="ListItemUitilityServices" Version="2.0.0" />
    <PackageVersion Include="MathUtilityServices" Version="2.0.0" />
    <PackageVersion Include="StringUtilityServices" Version="2.0.0" />
    <PackageVersion Include="NetRuntimeUtilityServices" Version="[2.0.0-preview-1.0.0]" />
    <PackageVersion Include="ILoggerBuilderFactoryServices" Version="[2.0.0-preview-1.0.0]" />
    <PackageVersion Include="LoggingCodeTemplateGenerators" Version="2.0.0" />
    <PackageVersion Include="IOOperationUtilityServices" Version="[5.0.0-preview-1.0.0]" />
    <PackageVersion Include="EntriesAndTheirContentsServices" Version="[1.0.0-preview-1.0.0]" />
    <PackageVersion Include="SortingUtilityServices" Version="1.0.1" />
    <PackageVersion Include="CommonModels" Version="2.1.0" />
    <PackageVersion Include="ConsoleUtilityServices" Version="1.0.0" />
    <PackageVersion Include="FileCategorizationUtilityServices" Version="2.0.0" />
  </ItemGroup>
  <ItemGroup>
    <PackageVersion Include="CliUtilityServices" Version="[4.0.0-preview-1.0.0]" />
    <PackageVersion Include="EnvironmentUtilityServices" Version="3.0.0" />
    <PackageVersion Include="DriveInfoUtilityServices" Version="1.0.0-preview-1.0.0" />
    <PackageVersion Include="SymbolicLinkUtilityServices" Version="1.0.0-preview-1.0.0" />
  </ItemGroup>
  <ItemGroup>
    <PackageVersion Include="ProjectsVersionUtilityServices" Version="1.0.0" />
    <PackageVersion Include="SolutionUtilityServices" Version="[5.0.0-preview-1.0.0]" />
    <PackageVersion Include="PaketUtilityServices" Version="1.0.0" />
  </ItemGroup>
  <ItemGroup>
    <PackageVersion Include="ProgrammingLanguageUtilityServices" Version="1.0.0" />
  </ItemGroup>
  <ItemGroup>
    <PackageVersion Include="ScriptDiscoveryUtilityServices" Version="1.0.0" />
  </ItemGroup>
  <ItemGroup>
    <PackageVersion Include="SharedUtilityServices" Version="1.0.0" />
  </ItemGroup>
</Project>
````

## File: Example-Projects/Ex4/Ex4-8/Bad-Example/Bad-Example.csproj
````
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <RootNamespace>Bad_Example</RootNamespace>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <IsPackable>false</IsPackable>
  </PropertyGroup>
  
  <ItemGroup>
    <PackageReference Include="coverlet.collector" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" />
    <PackageReference Include="xunit" />
    <PackageReference Include="xunit.runner.visualstudio" />
  </ItemGroup>
  <ItemGroup>
    <Using Include="Xunit" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\Calculator\Calculator.csproj" />
  </ItemGroup>
  
  <ItemGroup>
    <PackageReference Include="FluentAssertions" />
  </ItemGroup>

</Project>
````

## File: Example-Projects/Ex4/Ex4-8/Bad-Example/MultipleActTasksInOneTestCaseExample.cs
````csharp
using FluentAssertions;
using StringCalculatorUtilityServices;

namespace Bad_Example;

public class MultipleActTasksInOneTestCaseExample
{
    private readonly StringCalculator _stringCalculator = new();
    public MultipleActTasksInOneTestCaseExample()
    {
        _stringCalculator = new();
    }

    [Fact]
    public void MultipleActTasksInOneTestCaseExample_PollutesTheGlobalProperty_ThusAssertionsMayNotBeExpected()
    {
        // Act
        var actual1 = _stringCalculator.Add("");
        var currentItemAfterFirstOp = _stringCalculator.CurrentItem;
        
        var actual2 = _stringCalculator.Add(",");
        var currentItemAfterSecondOp = _stringCalculator.CurrentItem;
        
        var historyItemsAfterOp = _stringCalculator.HistoryItems;

        // Assert
        actual1.Should().Be(0);
        actual2.Should().Be(0);
        historyItemsAfterOp.Should().HaveCount(2);

        currentItemAfterFirstOp.Should().Be("");

        currentItemAfterSecondOp.Should().Be(",");
    }
}
````

## File: Example-Projects/Ex4/Ex4-8/Calculator/Calculator.csproj
````
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>
</Project>
````

## File: Example-Projects/Ex4/Ex4-8/Calculator/StringCalculator.cs
````csharp
namespace StringCalculatorUtilityServices;

public class StringCalculator
{
    private bool _isFirstTime = true;
    public List<string> HistoryItems { get; private set; }
    public string CurrentItem { get; private set; }
    public StringCalculator(
        List<string>? items = null
    )
    {
        HistoryItems = items ?? new List<string>();
    }
    public int Add(string item)
    {
        // Only update when the first method call.
        if (_isFirstTime)
        {
            CurrentItem = item;
        }
        HistoryItems.Add(item);
        var items = item.Split(",").Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
        _isFirstTime = false;
        return items.Count;
    }
}
````

## File: Example-Projects/Ex4/Ex4-8/Example-Project-4-8.slnx
````
<Solution>
  <Project Path="Bad-Example/Bad-Example.csproj" />
  <Project Path="Calculator/Calculator.csproj" />
  <Project Path="Good-Example/Good-Example.csproj" />
</Solution>
````

## File: Example-Projects/Ex4/Ex4-8/Good-Example/Good-Example.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <RootNamespace>Good_Example</RootNamespace>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <IsPackable>false</IsPackable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="coverlet.collector" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" />
    <PackageReference Include="xunit" />
    <PackageReference Include="xunit.runner.visualstudio" />
  </ItemGroup>

  <ItemGroup>
    <Using Include="Xunit" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\Calculator\Calculator.csproj" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="FluentAssertions" />
  </ItemGroup>


</Project>
````

## File: Example-Projects/Ex4/Ex4-8/Good-Example/SingleActTaskInOneTestCaseExample.cs
````csharp
using FluentAssertions;
using StringCalculatorUtilityServices;

namespace Good_Example;

public class SingleActTaskInOneTestCaseExample
{
    private readonly StringCalculator _stringCalculator = new();
    public SingleActTaskInOneTestCaseExample()
    {
        _stringCalculator = new();
    }

    [Theory]
    [InlineData("", 0)]
    [InlineData(",", 0)]
    public void SingleActTasksInOneTestCaseExample_NeverPollutesTheGlobalProperty_ThusAssertionsAreExpected(
        string input,
        int expected
    )
    {
        // Arrange
        // Act
        var actual = _stringCalculator.Add(input);
        var currentItemAfterFirstOp = _stringCalculator.CurrentItem;
        var historyItemsAfterOp = _stringCalculator.HistoryItems;

        // Assert
        actual.Should().Be(expected);
        historyItemsAfterOp.Should().HaveCount(1);
        currentItemAfterFirstOp.Should().Be(input);
    }
}
````

## File: Example-Projects/Ex4/Ex4-9/Bad-Example/Bad-Example.csproj
````
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <RootNamespace>Bad_Example</RootNamespace>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <IsPackable>false</IsPackable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="coverlet.collector" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" />
    <PackageReference Include="xunit" />
    <PackageReference Include="xunit.runner.visualstudio" />
  </ItemGroup>

  <ItemGroup>
    <Using Include="Xunit" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\Calculator\Calculator.csproj" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="Moq" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="FluentAssertions" />
  </ItemGroup>
  
</Project>
````

## File: Example-Projects/Ex4/Ex4-9/Bad-Example/TightCoupledClassTests.cs
````csharp
using CalculatorUtilityServices;
using FluentAssertions;

namespace Bad_Example;

/// <summary>
/// Wrong Example, use Design Pattern.
/// </summary>
public class TightCoupledClassTests
{
    private readonly TightCoupledCalculator _priceCalculator;
    public TightCoupledClassTests()
    {
        _priceCalculator = new();
    }

    [Fact]
    public void GetDiscountedPrice_NotTuesday_ReturnsFullPrice()
    {
        var actual = _priceCalculator.GetDiscountedPrice(2);
        actual.Should().Be(2);
    }

    [Fact]
    public void GetDiscountedPrice_OnTuesday_ReturnsHalfPrice()
    {
        var actual = _priceCalculator.GetDiscountedPrice(2);

        actual.Should().Be(1);
    }
}
````

## File: Example-Projects/Ex4/Ex4-9/Calculator/Calculator.csproj
````
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>
</Project>
````

## File: Example-Projects/Ex4/Ex4-9/Calculator/IDateTimeProvider.cs
````csharp
namespace CalculatorUtilityServices;

public interface IDateTimeProvider
{
    DayOfWeek DayOfWeek();
}
````

## File: Example-Projects/Ex4/Ex4-9/Calculator/LooseCoupledCalculator.cs
````csharp
namespace CalculatorUtilityServices;

/// <summary>
/// If one uses this loosely-coupled calculator, 
/// then one can easily mock the value used internally, 
/// therefore, it is possible to cover all uses cases (and edge class).
/// </summary>
public class LooseCoupledCalculator
{
    public int GetDiscountedPrice(int price, IDateTimeProvider dateTimeProvider)
    {
        if (dateTimeProvider.DayOfWeek() == DayOfWeek.Tuesday)
        {
            return price / 2;
        }
        else
        {
            return price;
        }
    }
}
````

## File: Example-Projects/Ex4/Ex4-9/Calculator/TightCoupledCalculator.cs
````csharp
namespace CalculatorUtilityServices;

/// <summary>
/// If one uses this tight-coupled calculator, 
/// then one can't mock the value used internally, 
/// consequently, it is impossible to cover all uses cases (and edge class).
/// </summary>
/// <remark>
/// See <see cref="global::CalculatorUtilityServices.LooseCoupledCalculator"/> for the explanation of better design.
/// </remark>
public class TightCoupledCalculator
{
    public int GetDiscountedPrice(int price)
    {
        if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
        {
            return price / 2;
        }
        else
        {
            return price;
        }
    }
}
````

## File: Example-Projects/Ex4/Ex4-9/Example-Project-4-9.slnx
````
<Solution>
  <Project Path="Bad-Example/Bad-Example.csproj" />
  <Project Path="Calculator/Calculator.csproj" />
  <Project Path="Good-Example/Good-Example.csproj" />
</Solution>
````

## File: Example-Projects/Ex4/Ex4-9/Good-Example/Good-Example.csproj
````
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <RootNamespace>Good_Example</RootNamespace>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <IsPackable>false</IsPackable>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="coverlet.collector" />
    <PackageReference Include="Microsoft.NET.Test.Sdk" />
    <PackageReference Include="xunit" />
    <PackageReference Include="xunit.runner.visualstudio" />
  </ItemGroup>
  <ItemGroup>
    <Using Include="Xunit" />
  </ItemGroup>
  <ItemGroup>
    <ProjectReference Include="..\Calculator\Calculator.csproj" />
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="Moq" />
  </ItemGroup>
  <ItemGroup>
    <PackageReference Include="FluentAssertions" />
  </ItemGroup>
</Project>
````

## File: Example-Projects/Ex4/Ex4-9/Good-Example/LooseCoupledClassTests.cs
````csharp
using CalculatorUtilityServices;
using FluentAssertions;
using Moq;

namespace Good_Example;

public class LooseCoupledClassTests
{
    private LooseCoupledCalculator _priceCalculator;
    private Mock<IDateTimeProvider> _mockDateTimeProvider;
    public LooseCoupledClassTests()
    {
        Setup();
    }

    private void Setup()
    {
        _priceCalculator = new();
        _mockDateTimeProvider = new Mock<IDateTimeProvider>();
    }

    [Fact]
    public void GetDiscountedPrice_NotTuesday_ReturnsFullPrice()
    {
        // Arrange
        Setup();
        _mockDateTimeProvider.Setup(dtp => dtp.DayOfWeek()).Returns(DayOfWeek.Monday);

        // Act
        var actual = _priceCalculator.GetDiscountedPrice(2, _mockDateTimeProvider.Object);

        // Assert
        actual.Should().Be(2);
    }

    [Fact]

    public void GetDiscountedPrice_OnTuesday_ReturnsHalfPrice()
    {
        // Arrange
        Setup();
        _mockDateTimeProvider.Setup(dtp => dtp.DayOfWeek()).Returns(DayOfWeek.Tuesday);

        // Act
        var actual = _priceCalculator.GetDiscountedPrice(2, _mockDateTimeProvider.Object);

        // Assert
        actual.Should().Be(1);
    }
}
````

## File: Example-Projects/Ex4/Ex4-9/Results/Errors/description.md
````markdown
# description of [screenshot](BadDesignPatternExample#GetDiscountedPrice_NotTuesday_ReturnsFullPrice#WhenInTuesday.png)
因為(截圖)當天是星期二，且該方法無法被Mock任意一個星期幾，導致永遠進入不了非星期二的分支內，永遠只會回傳一半的價格。導致`GetDiscountedPrice_NotTuesday_ReturnsFullPrice`方法此時會因斷言不符合預期而該測試案例失敗。同理，也可套用到星期一到星期日。
````

## File: Example-Projects/Ex4/Ex4-9/Results/Errors/message.md
````markdown
# info

Test: all methods defined under `~\Example-Projects\Ex4\Ex4-9\Bad-Example\TightCoupledClassTests.cs` file.

+ `GetDiscountedPrice_NotTuesday_ReturnsFullPrice`

+ `GetDiscountedPrice_OnTuesday_ReturnsHalfPrice`

# description

one can use unit tests to see what happens if one doesn't abstract the logic check 

into a interface by `Wrapper Pattern`.

## result
One of two test case will not be passed.

### error message
See below figure.

### screnshot
[Demo](BadDesignPatternExample#GetDiscountedPrice_NotTuesday_ReturnsFullPrice#WhenInTuesday.png)

### Why?
Because we can't mock the date and it is impossible that today is either `Tuesday` or not `Tuesday` 

In this screenshot (at 2026/06/09), 

`DateTime.Now.DayOfWeek == DayOfWeek.Tuesday` will always true 

consequently, it always reaches the `Tuesday` branch,

returning the half of price.
````

## File: Example-Projects/Ex4/Ex4-9/Results/Success/message.md
````markdown
# info

Test: all methods defined under `~\Example-Projects\Ex4\Ex4-9\Bad-Example\TightCoupledClassTests.cs` file.

+ `GetDiscountedPrice_NotTuesday_ReturnsFullPrice`

+ `GetDiscountedPrice_OnTuesday_ReturnsHalfPrice`

# description

one can use unit tests to see what happens if one abstracts the logic check 

into a interface by `Wrapper Pattern` and its advantages.

## result
All test cases will be passed.

### screnshot
[Demo](AllTestsPass.png)

### Why?
Because we can mock the date (to any date of week) 

In this screenshot (at 2026/06/09), 

`DateTime.Now.DayOfWeek == DayOfWeek.Tuesday` will always true 

thus, it is possible to coverage all branches,

returning the half of price according to the mocked date.
````

## File: Examples/Ex4/Bad-Ex4-1.cs
````csharp
using System;
using System.IO;
using System.Linq;

namespace ImplicitDependencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer()
            {
                FavoriteColor = "Blue",
                Title = "Mr.",
                Fullname = "Steve Smith"
            };
            Context.CurrentCustomer = customer;

            var response = new PersonalizedResponse();

            Console.WriteLine(response.GetResponse());
            Console.ReadLine();
        }
    }

    public static class Context
    {
        public static Customer CurrentCustomer { get; set; }

        public static void Log(string message)
        {
            using (StreamWriter logFile = new StreamWriter(
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "logfile.txt")))
            {
                logFile.WriteLine(message);
            }
        }
    }

    public class Customer
    {
        public string FavoriteColor { get; set; }
        public string Title { get; set; }
        public string Fullname { get; set; }
    }

    public class PersonalizedResponse
    {
        public string GetResponse()
        {
            Context.Log("Generating personalized response.");
            string formatString = "Good {0}, {1} {2}! Would you like a {3} widget today?";
            string timeOfDay = "afternoon";
            if (DateTime.Now.Hour < 12)
            {
                timeOfDay = "morning";
            }
            if (DateTime.Now.Hour > 17)
            {
                timeOfDay = "evening";
            }
            return String.Format(formatString, timeOfDay,
                Context.CurrentCustomer.Title,
                Context.CurrentCustomer.Fullname,
                Context.CurrentCustomer.FavoriteColor);
        }
    }
}
````

## File: Examples/Ex4/Bad-Ex4-2.cs
````csharp
[Fact]
public void Test_Single()
{
    var stringCalculator = new StringCalculator();

    var actual = stringCalculator.Add("0");

    Assert.Equal(0, actual);
}
````

## File: Examples/Ex4/Bad-Ex4-3.cs
````csharp
[Fact]
public void Add_EmptyString_ReturnsZero()
{
    // Arrange
    var stringCalculator = new StringCalculator();

    // Assert
    Assert.Equal(0, stringCalculator.Add(""));
}
````

## File: Examples/Ex4/Bad-Ex4-4.cs
````csharp
[Fact]
public void Add_SingleNumber_ReturnsSameNumber()
{
    var stringCalculator = new StringCalculator();

    var actual = stringCalculator.Add("42");

    Assert.Equal(42, actual);
}
````

## File: Examples/Ex4/Bad-Ex4-6.cs
````csharp
[Fact]
public void Add_MultipleNumbers_ReturnsCorrectResults()
{
    var stringCalculator = new StringCalculator();
    var expected = 0;
    var testCases = new[]
    {
        "0,0,0",
        "0,1,2",
        "1,2,3"
    };

    foreach (var test in testCases)
    {
        Assert.Equal(expected, stringCalculator.Add(test));
        expected += 3;
    }
}
````

## File: Examples/Ex4/Bad-Ex4-7-2.cs
````csharp
using System;
using System.IO.Abstractions;
using FluentAssertions;
using Moq;
using Xunit;

namespace EnvironmentUtilityServices.Tests;

public class OsUtilityServiceTests
{
    private readonly Mock<IFileSystem> _fileSystemMock;
    private readonly Mock<IEnvironmentService> _environmentServiceMock;

    public OsUtilityServiceTests()
    {
        // 防禦設定：明確將 Mock 設為嚴格模式或預設值防禦，防止平行時空未設定的導覽屬性噴錯
        _fileSystemMock = new Mock<IFileSystem>(MockBehavior.Strict);
        _environmentServiceMock = new Mock<IEnvironmentService>(MockBehavior.Strict);
    }

    [Fact]
    public void GetComparison_WhenIsWindowsIsTrue_ShouldReturnOrdinalIgnoreCase()
    {
        // Arrange
        _environmentServiceMock.Setup(x => x.IsWindows()).Returns(true);
        var sut = new OsUtilityService(_fileSystemMock.Object, _environmentServiceMock.Object);

        // Act
        var result = sut.GetComparison();

        // Assert
        result.Should().Be(StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public void GetComparison_WhenIsWindowsIsFalse_ShouldReturnOrdinal()
    {
        // Arrange
        _environmentServiceMock.Setup(x => x.IsWindows()).Returns(false);
        var sut = new OsUtilityService(_fileSystemMock.Object, _environmentServiceMock.Object);

        // Act
        var result = sut.GetComparison();

        // Assert
        result.Should().Be(StringComparison.Ordinal);
    }

    [Fact]
    public void NormalizePath_WhenPathIsInvalid_ShouldThrowArgumentExceptionWithCorrectMessage()
    {
        // Arrange
        var sut = new OsUtilityService(_fileSystemMock.Object, _environmentServiceMock.Object);

        // Act
        Action act = () => sut.NormalizePath("   ");

        // Assert
        act.Should().Throw<ArgumentException>()
           .WithMessage("*Path cannot be null or empty.*")
           .Which.ParamName.Should().Be("path");
    }

    [Fact]
    public void NormalizePath_WhenPathIsValid_ShouldReturnFullPathFromMockedFileSystem()
    {
        // Arrange
        var inputPath = "relative/path/file.txt";
        var expectedFullPath = @"C:\src\relative\path\file.txt";

        // 副作用防禦：明確 Mock 底層導覽屬性 Path，嚴防 NotSupportedException
        var pathMock = new Mock<IPath>();
        pathMock.Setup(p => p.GetFullPath(inputPath)).Returns(expectedFullPath);
        _fileSystemMock.Setup(fs => fs.Path).Returns(pathMock.Object);

        var sut = new OsUtilityService(_fileSystemMock.Object, _environmentServiceMock.Object);
        // Act
        var result = sut.NormalizePath(inputPath);

        // Assert
        result.Should().Be(expectedFullPath);
        _fileSystemMock.Verify(fs => fs.Path, Times.Once);
    }
}
````

## File: Examples/Ex4/Bad-Ex4-8-sematically-equivalence.cs
````csharp
[Fact]
public void Add_EmptyEntries_ShouldBeTreatedAsZero()
{    
    var inputValues = new string[2] {",",""};
    var actualValues = new int[2];
    var expectedValues = new int[2]{0,0}; 

    for(int i=0;i<inputValues.Length;i++)
    {
        // Arrange
        var stringCalculator = new StringCalculator();
        // Act
        var inputValue = inputValues[i];
        var actualValue = stringCalculator.Add(inputValue);
        var expectedValue = expectedValues[i];
        Assert.Equal(expectedValue,actualValue);
    }
}
````

## File: Examples/Ex4/Bad-Ex4-8.cs
````csharp
[Fact]
public void Add_EmptyEntries_ShouldBeTreatedAsZero()
{
    // Act
    var actual1 = stringCalculator.Add("");
    var actual2 = stringCalculator.Add(",");

    // Assert
    Assert.Equal(0, actual1);
    Assert.Equal(0, actual2);
}
````

## File: Examples/Ex4/Good-Ex4-1.cs
````csharp
using System;
using System.IO;
using System.Linq;

namespace ExplicitDependencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer()
            {
                FavoriteColor = "Blue",
                Title = "Mr.",
                Fullname = "Steve Smith"
            };

            var response = new PersonalizedResponse(new SimpleFileLogger(), new SystemDateTime());

            Console.WriteLine(response.GetResponse(customer));
            Console.ReadLine();
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class SimpleFileLogger : ILogger
    {
        public void Log(string message)
        {
            using (StreamWriter logFile = new StreamWriter(
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "logfile.txt")))
            {
                logFile.WriteLine(message);
            }
        }
    }

    public interface IDateTime
    {
        DateTime Now { get; }
    }

    public class SystemDateTime : IDateTime
    {
        public DateTime Now
        {
            get
            {
                return DateTime.Now;
            }
        }
    }

    public class Customer
    {
        public string FavoriteColor { get; set; }
        public string Title { get; set; }
        public string Fullname { get; set; }
    }

    public class PersonalizedResponse
    {
        private readonly ILogger _logger;

        private readonly IDateTime _dateTime;

        public PersonalizedResponse(ILogger logger,
            IDateTime dateTime)
        {
            this._dateTime = dateTime;
            this._logger = logger;
        }

        public string GetResponse(Customer customer)
        {
            _logger.Log("Generating personalized response.");
            string formatString = "Good {0}, {1} {2}! Would you like a {3} widget today?";
            string timeOfDay = "afternoon";
            if (_dateTime.Now.Hour < 12)
            {
                timeOfDay = "morning";
            }
            if (_dateTime.Now.Hour > 17)
            {
                timeOfDay = "evening";
            }
            return String.Format(formatString, timeOfDay,
                customer.Title,
                customer.Fullname,
                customer.FavoriteColor);
        }
    }
}
````

## File: Examples/Ex4/Good-Ex4-2.cs
````csharp
[Fact]
public void Add_SingleNumber_ReturnsSameNumber()
{
    var stringCalculator = new StringCalculator();

    var actual = stringCalculator.Add("0");

    Assert.Equal(0, actual);
}
````

## File: Examples/Ex4/Good-Ex4-3.cs
````csharp
[Fact]
public void Add_EmptyString_ReturnsZero()
{
    // Arrange
    var stringCalculator = new StringCalculator();

    // Act
    var actual = stringCalculator.Add("");

    // Assert
    Assert.Equal(0, actual);
}
````

## File: Examples/Ex4/Good-Ex4-4.cs
````csharp
[Fact]
public void Add_SingleNumber_ReturnsSameNumber()
{
    var stringCalculator = new StringCalculator();

    var actual = stringCalculator.Add("0");

    Assert.Equal(0, actual);
}
````

## File: Examples/Ex4/Good-Ex4-6.cs
````csharp
[Theory]
[InlineData("0,0,0", 0)]
[InlineData("0,1,2", 3)]
[InlineData("1,2,3", 6)]
public void Add_MultipleNumbers_ReturnsSumOfNumbers(string input, int expected)
{
    var stringCalculator = new StringCalculator();

    var actual = stringCalculator.Add(input);

    Assert.Equal(expected, actual);
}
````

## File: Examples/Ex4/Good-Ex4-7-2.cs
````csharp
using System;
using System.IO.Abstractions;
using FluentAssertions;
using Moq;
using Xunit;

namespace EnvironmentUtilityServices.Tests;

public class OsUtilityServiceTests
{
    private readonly Mock<IFileSystem> _fileSystemMock;
    private readonly Mock<IEnvironmentService> _environmentServiceMock;

    public OsUtilityServiceTests()
    {
        // 防禦設定：明確將 Mock 設為嚴格模式或預設值防禦，防止平行時空未設定的導覽屬性噴錯
        _fileSystemMock = new Mock<IFileSystem>(MockBehavior.Strict);
        _environmentServiceMock = new Mock<IEnvironmentService>(MockBehavior.Strict);
    }

    private OsUtilityService CreateSut()
    {
        return new OsUtilityService(_fileSystemMock.Object, _environmentServiceMock.Object);
    }

    [Fact]
    public void GetComparison_WhenIsWindowsIsTrue_ShouldReturnOrdinalIgnoreCase()
    {
        // Arrange
        _environmentServiceMock.Setup(x => x.IsWindows()).Returns(true);
        var sut = CreateSut();

        // Act
        var result = sut.GetComparison();

        // Assert
        result.Should().Be(StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public void GetComparison_WhenIsWindowsIsFalse_ShouldReturnOrdinal()
    {
        // Arrange
        _environmentServiceMock.Setup(x => x.IsWindows()).Returns(false);
        var sut = CreateSut();

        // Act
        var result = sut.GetComparison();

        // Assert
        result.Should().Be(StringComparison.Ordinal);
    }

    [Fact]
    public void NormalizePath_WhenPathIsInvalid_ShouldThrowArgumentExceptionWithCorrectMessage()
    {
        // Arrange
        var sut = CreateSut();

        // Act
        Action act = () => sut.NormalizePath("   ");

        // Assert
        act.Should().Throw<ArgumentException>()
           .WithMessage("*Path cannot be null or empty.*")
           .Which.ParamName.Should().Be("path");
    }

    [Fact]
    public void NormalizePath_WhenPathIsValid_ShouldReturnFullPathFromMockedFileSystem()
    {
        // Arrange
        var inputPath = "relative/path/file.txt";
        var expectedFullPath = @"C:\src\relative\path\file.txt";

        // 副作用防禦：明確 Mock 底層導覽屬性 Path，嚴防 NotSupportedException
        var pathMock = new Mock<IPath>();
        pathMock.Setup(p => p.GetFullPath(inputPath)).Returns(expectedFullPath);
        _fileSystemMock.Setup(fs => fs.Path).Returns(pathMock.Object);

        var sut = CreateSut();

        // Act
        var result = sut.NormalizePath(inputPath);

        // Assert
        result.Should().Be(expectedFullPath);
        _fileSystemMock.Verify(fs => fs.Path, Times.Once);
    }
}
````

## File: Examples/Ex4/Good-Ex4-8.cs
````csharp
[Theory]
[InlineData("", 0)]
[InlineData(",", 0)]
public void Add_EmptyEntries_ShouldBeTreatedAsZero(string input, int expected)
{
    // Arrange
    var stringCalculator = new StringCalculator();

    // Act
    var actual = stringCalculator.Add(input);

    // Assert
    Assert.Equal(expected, actual);
}
````

## File: LICENSE
````
MIT License

Copyright (c) 2026 jayhuang30

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
````

## File: README.md
````markdown
# Unit-Testing
Discuss the importance of Unit Test and which principles are need to be applied
````

## File: Examples/Ex4/Bad-Ex4-5.cs
````csharp
[Fact]
public void Add_BigNumber_ThrowsException()
{
    var stringCalculator = new StringCalculator();

    Action actual = () => stringCalculator.Add("1001");

    Assert.Throws<OverflowException>(actual);
}
````

## File: Examples/Ex4/Good-Ex4-5.cs
````csharp
[Fact]
void Add_MaximumSumResult_ThrowsOverflowException()
{
    var stringCalculator = new StringCalculator();
    const string MAXIMUM_RESULT = "1001";

    Action actual = () => stringCalculator.Add(MAXIMUM_RESULT);

    Assert.Throws<OverflowException>(actual);
}
````

## File: tutorials/CH4 -- Best practices of Unit Test.md
````markdown
# CH4 -- Best practices of Unit Test
## objectives
In this article, you will learn principles that you need to apply when you write unit tests.

## CH4-1 -- Avoid infrastructure dependencies
It means that you should not make your code as [spaghetii code](https://en.wikipedia.org/wiki/Spaghetti_code)

which means one should make a utility class as less couple as one can (and also use interface), 

since one can easily just mock the method to test the functionality behaves as expected.

### Examples
#### Example 1
Compare these two code snippets

[Implicit Dependencies Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Bad-Ex4-1.cs)

[Explicit Dependencies Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Good-Ex4-1.cs)

Observe these above two code snippets.

You can easily find that

+ In `Implicit Dependencies Example` example,

the `Log` method defined in `PersonalizedResponse` class depends on a global value -- `Context.CurrentCustomer`.

And thus, the behavior of the `Log` method defined in `PersonalizedResponse` class will be affected by global variables (or property etc)

It is fatal, because

    - when one needs to log different message, one needs to modify the `Log` method defined in `PersonalizedResponse` class.

making it less maintainability and less flexible. 

Thus, one can say it is highly-coupled.

+ On the other hand, in `Explicit Dependencies Example` exmaple,

the `Log` method defined in `PersonalizedResponse` class depends on the value of arguments of this method call.

There are some advantages.

    - when one needs to log different message, one don't need to modify the `Log` method defined in `PersonalizedResponse` class,

    one just needs to passed different value to this method

making it more maintainability and more flexible.

Thus, one can say it is less-coupled.

## CH4-2 -- Follow test naming standards

The name of your test should consist of three parts:

+ Name of the method being tested

+ Scenario under which the method is being tested

+ Expected behavior when the scenario is invoked

Following test naming standards are really important because

one can quickly know what does it means and its expected behavior.

### Examples
#### Example 1
Compare these two code snippets

[Less Readable Name Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Bad-Ex4-2.cs)

[More Readable Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Good-Ex4-2.cs)


+ In `More Readable Example` example, 

one can easily and quickly know what does it test case do (only need scanning by eyes)

Adding a zero using `StringCalculator` are expected to return same value `0`.

+ However, on the other hand, in `Less Readable Name Example` example,

one can't easily and quickly know what does it test case do by just looking the method name of test case.

One needs to read the full method definition of the test case, which takes longer time and consumes more patience.

## CH4-3 -- Arrange your tests
In one test case, it is always required

+ Arrange: Arrange your objects, create, and configure them as necessary

+ Act: Act on an object

+ Assert: Assert that something is as expected

It should neither merge actions into assertions (always inhibited) nor 

merge arrangement into actions (as possible as one can, there are a little extremely test case that must need to do so)

since it is less readable and 

when an exception thrown in assertion, it is harder to debug which the exception is from. 

Statements about act? 

Or from assertions?

Additionally, the return value of the action can't be reused 

and violates SRP (Single-Response Principle)

### Examples
#### Example 1
Compare these two code snippets

[Unit Test with Bad Arrangements Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Bad-Ex4-3.cs)

[Unit Test with Good Arrangements Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Good-Ex4-3.cs)

+ In `Unit Test with Bad Arrangement Example`,

in one statement, it acts the object and check the return value of the action.

+ One the other hand, in `Unit Test with Good Arrangement Example`,

one can easily and quickly see which arrangment it is, which action it is, which assertions they are. 

Additionally, it has other benefits,

+ it can prevent the pollution of input of different set of input case, making each set of input set are independent.

+ it can make it more readable for reader.

## CH4-4 -- Write minimally passing tests
Write it as simple as one can in any test case.

If one needs to test the other cases, please write the other test cases. 

### Examples
#### Example 1
Compare these two code snippets

[Unit Test with Misleading Content Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Bad-Ex4-4.cs)

[Unit Test without Misleading Content Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Good-Ex4-4.cs)

+ In `Unit Test with Misleading Content Example`,

when one see `var actual = stringCalculator.Add("42");`,

the one might be confused why developer needs to add `42`, not `0`?

+ One the other hand, in `Unit Test without Misleading Content Example`,

one may not be confused why developer needs to add `0`? 

Because the method name `Add_SingleNumber_ReturnsSameNumber()` clearly says 

after adding a a number (let's called `n`) to an another single number, it is expected to be equal the original one (`n`),

and it is ensured that adding a number to zero is always equal to the number itself. 

## CH4-5 -- Avoid magic numbers or strings
Avoiding any magic numbers or string without any extra comment or context since 

these values make it less readable (and cause confusion to the reader) and harder to maintain.

### Examples
#### Example 1
Compare these two code snippets

[Unit Test with Magical Strings Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Bad-Ex4-5.cs)

[Unit Test without Magical Strings Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Good-Ex4-5.cs)

`Unit Test without Magical Strings Example` is obviously more readable for readers and more maintenable, isn't it?

## CH4-6 -- Avoid coding logic in unit tests
Never coding logic in unit tests. 

To do so, you can use one `[Theory]` Data Annotation and a series of `[InlineData]` Data Annotation.

See following examples for its pros.

### Examples
#### Example 1
Compare these two code snippets

[Unit Test containing Coding Logic Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Bad-Ex4-6.cs)

[Unit Test Not containing Coding Logic Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Good-Ex4-6.cs)

+ In `Unit Test containing Coding Logic Example` example,

value of `expected` is dynamically calculated in a `for` loop.

+ While, on the other hand, in `Unit Test Not containing Coding Logic Example` example,

the `expected` is one of the parameters of the method.

Thus, it doesn't need to dynamically calculate the value of `expected`.

It is more readable for reader and more maintenable.

Additionally, the test runner will consider there are many test cases, making it more debuggable.

See [example of CH4-8] for more understanding.

Image a situation:

If one can't find regularity among the sequence of expected value,

it is much harder to get value of `expected`.

It is a disaster.


## CH4-7 -- Extract the setup logic to helper methods (especially for complex logic)

For complex logic, it is recommended to extract the setup logic to helper methods since

there are some advantages that modularity has.

+ More readable.

+ High reusability

+ More flexible: Just needs to pass different value as arguments.

### Examples
#### Example 1
Compare these two code snippets

[Unit Test containing Coding Logic Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Bad-Ex4-7-2.cs)

[Unit Test Not containing Coding Logic Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Good-Ex4-7-2.cs)

In `Unit Test Not containing Coding Logic Example` example (actual scenario written when I developed the utility packages),

 although I can refactor it, making it more readable,

 it is more maintenable and readable than `Unit Test containing Coding Logic Example` example, isn't it?
 
## CH4-8 -- Avoid multiple Act tasks in one input test
Let's compare these examples to quickly review the advantages mentioned in [CH4-7]()

### Examples
#### Example 1
Compare these two code snippets

[Multiple Act Tasks in One Input Test Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Bad-Ex4-8.cs)

[Single Act Task in One Input Test Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Good-Ex4-8.cs)

+ In `Multiple Act Tasks in One Input Test Example` example, it is sematically equivalent to iterate all items of array 

such as [sematically Equivalent to Multiple Act Tasks in One Input Test Example](https://github.com/jayhuang30/Unit-Testing/blob/main/Examples/Ex4/Bad-Ex4-8-sematically-equivalence.cs)

Although it can work,

it has a little fatal potent bugs

    - it forces one to write boilerpolate code or to write a loop to iterate for each input set, and thus less readibility.

    - The test runner will consider there is one input set in one test method, making it less readable

+ On the other hand,

In `Single Act Task in One Input Test Example` example.

The test runner will consider there are one or more input sets (that reflects the actual number of test sets you want to) in one test method, making it more readable.

See examples for more details.

## CH4-9 -- Validate private methods with public methods

At present, the open-source `NuGet` package, it can **ONLY** mock the interfaces (thus can setup its behavior of the method that are implemented in `class`) and `virtual` methods 

(if one uses neither the `Source Generator` nor reflection nor other dangerous operations)

Similary, the open-source `NuGet` package, it can **ONLY** substitute interfaces and virtual methods as callback you want through intercepting them. 

(if one uses neither the `Source Generator` nor reflection nor other dangerous operations)

On the other hand,

An interface behaves like a contract, when a class implements an inteface, compiler will only forces the class that needs to implement these methods defined in the interface.

Thus, it is impossible to mock or substitute a `private` method.

The only way to be validate the `private` method is to validate the `public` methods (which it calls the `private` methods)
 
## References

+ [Unit testing best practices for .NET](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)
````
