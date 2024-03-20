namespace AoC;

public class Day3
{
    public static int Part1(string input)
    {
        var location = (0, 0);
        var set = new HashSet<(int, int)> { location };

        foreach (var dir in input)
        {
            location = DoStep(location, dir);
            set.Add(location);
        }
        
        return set.Count;
    }

    public static int Part2(string input)
    {
        var santa = (0, 0);
        var robot = (0, 0);
        var isSanta = true;
        var set = new HashSet<(int, int)> { santa };

        foreach (var dir in input)
        {
            if (isSanta)
            {
                santa = DoStep(santa, dir);
                set.Add(santa);
            }
            else
            {
                robot = DoStep(robot, dir);
                set.Add(robot);
            }
            
            isSanta = !isSanta;
        }

        return set.Count;
    }

    private static (int x, int y) DoStep((int x, int y) current, char direction)
    {
        return direction switch
        {
            '^' => (current.x, ++current.y),
            'v' => (current.x, --current.y),
            '>' => (++current.x, current.y),
            '<' => (--current.x, current.y),
            _ => throw new ArgumentException()
        };
    }
}