namespace Day1;

public class Part1Test
{
    [Theory]
    [InlineData("1abc2", 12)]
    [InlineData("pqr3stu8vwx", 38)]
    [InlineData("a1b2c3d4e5f", 15)]
    [InlineData("treb7uchet", 77)]
    public void TestParseLine(string input, int expected)
    {
        var actual = Logic.TrebuchetCalibrator.ParseLine(input);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestParseInput()
    {
        var input = "1abc2\npqr3stu8vwx\na1b2c3d4e5f\ntreb7uchet";
        var expected = 142;
        var actual = Logic.TrebuchetCalibrator.ParseInput(input);
        Assert.Equal(expected, actual);
    }
}