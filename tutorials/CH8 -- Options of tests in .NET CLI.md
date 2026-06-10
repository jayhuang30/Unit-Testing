# CH8 -- Options of tests in .NET CLI
## objectives
In this article, you will learn 

    + the options of `dotnet test`

## CH8-1 -- terminology
+ Response file:

A file containing options which its contents will be inline-replaced when it is specified.

+ Platform options:

Platform options let you to specify response file (`*.rsp`)

## CH8-2 -- Response file
+ Pros:

    - High Reusability: Let one don't need to write the whole options in every test.

    - Bypass the terminal max token limits since 
    
    one doesn't need to write the whole options in command line (it is written in file)

## References
+ [What is response file? (Gems Response)](https://gemini.google.com/share/f3ad58838576)

+ [Microsoft.Testing.Platform (MTP) CLI options reference](https://learn.microsoft.com/en-us/dotnet/core/testing/microsoft-testing-platform-cli-options)
