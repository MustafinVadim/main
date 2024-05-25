namespace Easy;

public class RomanToInteger
{
    public static int RomanToInt(string s)
    {
        var result = 0;
        var prevNumber = ' ';

        foreach (var number in s)
        {
            result += ParseNumber(number);
            result -= DownGrade(number, prevNumber);
            prevNumber = number;
        }

        return result;
    }

    private static int ParseNumber(char number)
    {
        return number switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => throw new ArgumentException("Unknown Roman numeral")
        };
    }

    private static int DownGrade(char number, char prev)
    {
        return number switch
        {
            'V' or 'X' when prev == 'I' => 2,
            'L' or 'C' when prev == 'X' => 20,
            'D' or 'M' when prev == 'C' => 200,
            _ => 0
        };
    }
}