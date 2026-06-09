# info

Test: all methods defined under `~\Example-Projects\Ex4\Ex4-9\Bad-Example\TightCoupledClassTests.cs` file.

+ `GetDiscountedPrice_NotTuesday_ReturnsFullPrice`

+ `GetDiscountedPrice_OnTuesday_ReturnsHalfPrice`

# description

one can use unit tests to see what happens if one abstracts the logic check 

into a interface by `Wrapper Pattern` and its advantages.

## result
All test cases will be passed.

### screnshot
[Demo](AllTestsPass.png)

### Why?
Because we can mock the date (to any date of week) 

In this screenshot (at 2026/06/09), 

`DateTime.Now.DayOfWeek == DayOfWeek.Tuesday` will always true 

thus, it is possible to coverage all branches,

returning the half of price according to the mocked date.



