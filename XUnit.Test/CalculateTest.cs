using XUnit.Console;

namespace XUnit.Test;

public class CalculateTest
{
    [Theory]
    [InlineData(2,3)]
    [InlineData(4,5)]
    [InlineData(6,7)]

    public void AddTest(int a , int b)
    {
        var calc = new Calculate();
        var correct = a + b;
        var result = calc.Add(a, b);

        Assert.True(correct == result);
    }
}