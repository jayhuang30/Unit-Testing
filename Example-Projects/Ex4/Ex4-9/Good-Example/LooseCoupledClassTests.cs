using CalculatorUtilityServices;
using FluentAssertions;
using Moq;

namespace Good_Example;

public class LooseCoupledClassTests
{
    private LooseCoupledCalculator _priceCalculator;
    private Mock<IDateTimeProvider> _mockDateTimeProvider;
    public LooseCoupledClassTests()
    {
        Setup();
    }

    private void Setup()
    {
        _priceCalculator = new();
        _mockDateTimeProvider = new Mock<IDateTimeProvider>();
    }

    [Fact]
    public void GetDiscountedPrice_NotTuesday_ReturnsFullPrice()
    {
        // Arrange
        Setup();
        _mockDateTimeProvider.Setup(dtp => dtp.DayOfWeek()).Returns(DayOfWeek.Monday);

        // Act
        var actual = _priceCalculator.GetDiscountedPrice(2, _mockDateTimeProvider.Object);

        // Assert
        actual.Should().Be(2);
    }

    [Fact]

    public void GetDiscountedPrice_OnTuesday_ReturnsHalfPrice()
    {
        // Arrange
        Setup();
        _mockDateTimeProvider.Setup(dtp => dtp.DayOfWeek()).Returns(DayOfWeek.Tuesday);

        // Act
        var actual = _priceCalculator.GetDiscountedPrice(2, _mockDateTimeProvider.Object);

        // Assert
        actual.Should().Be(1);
    }
}
