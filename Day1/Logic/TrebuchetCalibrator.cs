using CommonTools;

namespace Day1.Logic
{
    public class TrebuchetCalibrator
    {
        public static int ParseLine(string line) => int.Parse(new [] { line.First(char.IsDigit), line.Last(char.IsDigit) }.ToDelimitedString());

        public static int ParseLinePart2(string line) 
        {
            var firstDigit = line.Tails().Select(CheckLine).First(x => x.IsDigit).Value;
            var lastDigit = line.ReverseTails().Select(CheckLine).First(x => x.IsDigit).Value;

            return int.Parse(new [] { firstDigit, lastDigit }.ToDelimitedString());
        }

        public static (bool IsDigit, char Value) CheckLine(string line) 
        {
            if (char.IsDigit(line[0])) 
            {
                return (true, line[0]);
            }

            if (line.StartsWith("one")) 
            {
                return (true, '1');
            }

            if (line.StartsWith("two")) 
            {
                return (true, '2');
            }

            if (line.StartsWith("three")) 
            {
                return (true, '3');
            }

            if (line.StartsWith("four")) 
            {
                return (true, '4');
            }

            if (line.StartsWith("five")) 
            {
                return (true, '5');
            }

            if (line.StartsWith("six")) 
            {
                return (true, '6');
            }

            if (line.StartsWith("seven")) 
            {
                return (true, '7');
            }

            if (line.StartsWith("eight")) 
            {
                return (true, '8');
            }

            if (line.StartsWith("nine")) 
            {
                return (true, '9');
            }

            return (false, ' ');
        }

        public static int ParseInput(string input) => input.Split('\n').Select(ParseLine).Sum();
        public static int ParseInputPart2(string input) => input.Split('\n').Select(ParseLinePart2).Sum();
    }
}