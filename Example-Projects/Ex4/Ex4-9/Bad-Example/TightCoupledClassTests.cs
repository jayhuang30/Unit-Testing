using CalculatorUtilityServices;
using FluentAssertions;

namespace Bad_Example;

/// <summary>
/// Wrong Example, use Design Pattern.
/// </summary>
public class TightCoupledClassTests
{
    private readonly TightCoupledCalculator _priceCalculator;
    public TightCoupledClassTests()
    {
        _priceCalculator = new();
    }

    [Fact]
    public void GetDiscountedPrice_NotTuesday_ReturnsFullPrice()
    {
        var actual = _priceCalculator.GetDiscountedPrice(2);
        actual.Should().Be(2);
    }

    [Fact]
    public void GetDiscountedPrice_OnTuesday_ReturnsHalfPrice()
    {
        var actual = _priceCalculator.GetDiscountedPrice(2);

        actual.Should().Be(1);
    }
}
