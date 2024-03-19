namespace AoC;

public static class Day1
{
    public static int Part1(string data) => data.Aggregate(0, (count, next) => next == '(' ? count + 1 : count - 1);

    public static int Part2(string data)
    {
        var count = 0;
        var position = 0;
        
        foreach (var c in data)
        {
            position++;
            count = c == '(' ? count + 1 : count - 1;
            
            if (count == -1)
                return position;
        }

        throw new Exception();
    }
}