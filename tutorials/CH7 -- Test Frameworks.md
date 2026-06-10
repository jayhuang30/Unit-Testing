# CH7 -- Test Frameworks
## objectives
In this article, you will know these frameworks for testing.


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
+ [NUnit Documentation](https://docs.nunit.org/articles/nunit/intro.html)
+ [Getting Started with xUnit.net v2](https://xunit.net/docs/getting-started/v2/getting-started)
+ [Getting Started with xUnit.net v3](https://xunit.net/docs/getting-started/v3/getting-started)
+ [Gems Response](https://gemini.google.com/share/4468377c3a4a)
+ [Gems Response](https://gemini.google.com/share/50147cdae6ef)