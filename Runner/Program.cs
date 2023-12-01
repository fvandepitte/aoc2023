using Day1.Logic;

var day =  Environment.GetCommandLineArgs()[1];
var file =  Environment.GetCommandLineArgs()[2];
var input = File.ReadAllText(file);

var solution = day switch
{
    "Day1" => TrebuchetCalibrator.ParseInput(input).ToString(),
    _ => throw new ArgumentException("Invalid day")
};

Console.WriteLine(solution);

solution = day switch
{
    "Day1" => TrebuchetCalibrator.ParseInputPart2(input).ToString(),
    _ => throw new ArgumentException("Invalid day")
};

Console.WriteLine(solution);