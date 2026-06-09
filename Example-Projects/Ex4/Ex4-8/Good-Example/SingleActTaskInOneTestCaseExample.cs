using FluentAssertions;
using StringCalculatorUtilityServices;

namespace Good_Example;

public class SingleActTaskInOneTestCaseExample
{
    private readonly StringCalculator _stringCalculator = new();
    public SingleActTaskInOneTestCaseExample()
    {
        _stringCalculator = new();
    }

    [Theory]
    [InlineData("", 0)]
    [InlineData(",", 0)]
    public void SingleActTasksInOneTestCaseExample_NeverPollutesTheGlobalProperty_ThusAssertionsAreExpected(
        string input,
        int expected
    )
    {
        // Arrange
        // Act
        var actual = _stringCalculator.Add(input);
        var currentItemAfterFirstOp = _stringCalculator.CurrentItem;
        var historyItemsAfterOp = _stringCalculator.HistoryItems;

        // Assert
        actual.Should().Be(expected);
        historyItemsAfterOp.Should().HaveCount(1);
        currentItemAfterFirstOp.Should().Be(input);
    }
}
