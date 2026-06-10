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

You can look at the exception stack trace (if not caught by test framework) and 

give the full exception stack trace and its related files to 

ask AI Agent.

> [!WARNING]
> If one writes the assertion using test framework instead of `FluentAssertion` package,
>
> The exception stack trace will be thrown, see [CH9-1](../CH9%20--%20Packages#CH9-1%20--%20About%20assertions) for more details.

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
> The exception stack trace will be thrown, see [CH9-1](../CH9%20--%20Packages#CH9-1%20--%20About%20assertions)
> 
>  for more details.

#### Use `dotnet run`
You can simply run the test project to test the whole test cases defined in the project.

#### Use `dotnet exec`
You can also execute the assembly file `*.dll`

> [!NOTE]
> For more details, vist the page of links given in `References` section

## References
+ [Run and debug tests](https://learn.microsoft.com/en-us/dotnet/core/testing/microsoft-testing-platform-run-and-debug?tabs=dotnetcli)
