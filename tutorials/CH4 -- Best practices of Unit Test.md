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
