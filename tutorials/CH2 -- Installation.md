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

For summary, see ![this sheet](../Attachments/tutorials/prequisite-for-unit-test.xlsx)

## How to install?
### Using VSC as Code IDE
step 1:

download and install VSC from official site.

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

