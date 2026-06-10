# CH6 -- Test Platforms
## objectives
In this article, you will know these Platforms for testing.

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

    - A lightweight testing platform since it is standalone, not combined with console.

    - Fast: as it is lightweight.

+ Cons:

    - It only supports on newer framework (and newer architecture), and on `.NET` ecosystem. 

## References
+ [VSTest | GitHub repo](https://github.com/microsoft/vstest)

  + [MTP | GitHub repo](https://github.com/microsoft/testfx)
