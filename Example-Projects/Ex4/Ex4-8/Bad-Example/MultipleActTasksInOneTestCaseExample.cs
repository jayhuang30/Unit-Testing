using FluentAssertions;
using StringCalculatorUtilityServices;

namespace Bad_Example;

public class MultipleActTasksInOneTestCaseExample
{
    private readonly StringCalculator _stringCalculator = new();
    public MultipleActTasksInOneTestCaseExample()
    {
        _stringCalculator = new();
    }

    [Fact]
    public void MultipleActTasksInOneTestCaseExample_PollutesTheGlobalProperty_ThusAssertionsMayNotBeExpected()
    {
        // Act
        var actual1 = _stringCalculator.Add("");
        var currentItemAfterFirstOp = _stringCalculator.CurrentItem;
        
        var actual2 = _stringCalculator.Add(",");
        var currentItemAfterSecondOp = _stringCalculator.CurrentItem;
        
        var historyItemsAfterOp = _stringCalculator.HistoryItems;

        // Assert
        actual1.Should().Be(0);
        actual2.Should().Be(0);
        historyItemsAfterOp.Should().HaveCount(2);

        currentItemAfterFirstOp.Should().Be("");

        currentItemAfterSecondOp.Should().Be(",");
    }
}
