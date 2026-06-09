# info

Test: all methods defined under `~\Example-Projects\Ex4\Ex4-9\Bad-Example\TightCoupledClassTests.cs` file.

+ `GetDiscountedPrice_NotTuesday_ReturnsFullPrice`

+ `GetDiscountedPrice_OnTuesday_ReturnsHalfPrice`

# description

one can use unit tests to see what happens if one doesn't abstract the logic check 

into a interface by `Wrapper Pattern`.

## result
One of two test case will not be passed.

### error message
See below figure.

### screnshot
[Demo](BadDesignPatternExample#GetDiscountedPrice_NotTuesday_ReturnsFullPrice#WhenInTuesday.png)

### Why?
Because we can't mock the date and it is impossible that today is either `Tuesday` or not `Tuesday` 

In this screenshot (at 2026/06/09), 

`DateTime.Now.DayOfWeek == DayOfWeek.Tuesday` will always true 

consequently, it always reaches the `Tuesday` branch,

returning the half of price.



