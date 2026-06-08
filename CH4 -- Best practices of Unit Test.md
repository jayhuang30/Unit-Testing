# CH4 -- Best practices of Unit Test.md
## objectives
In this article, you will learn principles that you need to apply when you write unit tests.

## CH4-1 -- Avoid infrastructure dependencies
It means that you should not make your code as [spaghetii code](https://en.wikipedia.org/wiki/Spaghetti_code)

which means you should make a utility class as less couple as you can (and use interface), 

since one can easily just mock the method to test the functionality behaves as expected.

## CH4.2 -- Follow test naming standards

The name of your test should consist of three parts:

+ Name of the method being tested

+ Scenario under which the method is being tested

+ Expected behavior when the scenario is invoked

Following test naming standards are really important because

one can quickly know what does it means and its expected behavior.

For example,

```
[Fact]
public void Add_SingleNumber_ReturnsSameNumber()
{
    var stringCalculator = new StringCalculator();

    var actual = stringCalculator.Add("0");

    Assert.Equal(0, actual);
}
```

In this above example, one can easily know 

+ Adding a zero using `StringCalculator` are expected to return same value `0`.
