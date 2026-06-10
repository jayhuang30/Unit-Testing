# CH9 -- Packages
## objectives
In this article, you will know

+ commonly used packages for writing unit test

## CH9-1 -- About assertions
The test framework (published by Microsoft) supports assertions.

However, they are not fluent and 

catch the exception stack trace, 

so that if one tests on IDE, 

then one won't see the exception stack trace or exception stack trace is not conspicuous.

To resolve these disadvantages, 

simply install packages `FluentAssertions`

### `FluentAssertions`

`FluentAssertions` makes you write assertion fluently, as write a sentence in English.

For example:

With `FluentAssertions`, you can simply write

```
var actualValue = 2;
actualValue.Should().Be(expectedValue);
```

While without `FluentAssertions`, you may need to write

```
var actualValue = 2;
Assert.Equal(actualValue,expectedValue);
```

which makes it hard to read.

## CH9-2 -- About mocking
To mock an object behavior, you can simply use an excellent package 

+ `Moq`
+ `NSubstitute`

### Moq
`Moq` let you mock an object.

Then you manually setup the behavior (or return value) of a method (it can be used to simulate more complex scenario relative to `NSubstitute`.

> [!WARNING]
> `Moq` can only mock `interfaces` and non-static `virtual` methods
>
> If you want to mock the extension methods, it will be troublesome.
>
> See [`Moq`]() for more details. 

### NSubstitute
`NSubstitute` also let you mock the object and can setup the behavior (or return value) of 

a method with `AAA` (Arrange-Action-Assert) style, making it more readable.

> [!NOTE]
> For more comparison of `Moq` and `NSubstitute`,
> 
> See [Moq vs. NSubstitute: A Detailed Comparison](https://gist.github.com/cuteribs/3570ce7a5d8a9db876b207d1b041c651)

## References
+ [Introduction of FluentAssertions](https://xceed.com/documentation/xceed-fluent-assertions-for-net/)
+ [Moq vs. NSubstitute: A Detailed Comparison](https://gist.github.com/cuteribs/3570ce7a5d8a9db876b207d1b041c651)

