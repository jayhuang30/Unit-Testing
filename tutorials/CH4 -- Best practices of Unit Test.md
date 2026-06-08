# CH4 -- Best practices of Unit Test
## objectives
In this article, you will learn principles that you need to apply when you write unit tests.

## CH4-1 -- Avoid infrastructure dependencies
It means that you should not make your code as [spaghetii code](https://en.wikipedia.org/wiki/Spaghetti_code)

which means you should make a utility class as less couple as you can (and use interface), 

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
