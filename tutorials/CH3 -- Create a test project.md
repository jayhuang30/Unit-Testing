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

Next, go to solution panel by click the solution icon
![Solution-icon.png](../Attachments/tutorials/testing%20demo/Solution-icon.png)

Step 2:

If it detects there is no any solutions that is directly child of the root of workspace, 

that indicates you don't create a solution successfully.

Thus, you have to create a solution or open the solution on ![solution panel](../Attachments/tutorials/testing%20demo/Create-Solution-Or-Open-Solution.png)

Otherwise, do nothing, skip to step 3.

Step 3:

On solution panel,

right click the solution, 

select ![`Add new project` icon](../Attachments/tutorials/testing%20demo/Add-New-Project.png)

Step 4:

Follow its instruction to fill them into `Command Palette`.

Following figures illustrate which data you need to enter respectively.

![Add new project (2/5)](../Attachments/tutorials/testing%20demo/Create-New-Project-CommandPalette-step2.png)

![Add new project (3/5)](../Attachments/tutorials/testing%20demo/Create-New-Project-CommandPalette-step3.png)

![Add new project (4/5)](../Attachments/tutorials/testing%20demo/Create-New-Project-CommandPalette-step4.png)

![Add new project (5/5)](../Attachments/tutorials/testing%20demo/Create-New-Project-CommandPalette-step5.png)

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