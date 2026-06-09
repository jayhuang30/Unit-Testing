[Fact]
public void Add_EmptyEntries_ShouldBeTreatedAsZero()
{    
    var inputValues = new string[2] {",",""};
    var actualValues = new int[2];
    var expectedValues = new int[2]{0,0}; 

    for(int i=0;i<inputValues.Length;i++)
    {
        // Arrange
        var stringCalculator = new StringCalculator();
        // Act
        var inputValue = inputValues[i];
        var actualValue = stringCalculator.Add(inputValue);
        var expectedValue = expectedValues[i];
        Assert.Equal(expectedValue,actualValue);
    }
}
