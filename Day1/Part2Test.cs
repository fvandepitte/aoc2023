namespace Day1;

public class Part2Tests
{
    [Theory]
    [InlineData("two1nine", 29)]
    [InlineData("eightwothree", 83)]
    [InlineData("abcone2threexyz", 13)]
    [InlineData("xtwone3four", 24)]
    [InlineData("4nineeightseven2", 42)]
    [InlineData("zoneight234", 14)]
    [InlineData("7pqrstsixteen", 76)]
    [InlineData("9f", 99)]
    public void TestMethod(string input, int expectedOutput)
    {
        Assert.Equal(expectedOutput, Logic.TrebuchetCalibrator.ParseLinePart2(input));
    }
}