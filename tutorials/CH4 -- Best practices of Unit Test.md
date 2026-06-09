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
 
