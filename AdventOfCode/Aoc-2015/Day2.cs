namespace AoC;

public class Day2
{
    public static int Part1(List<string> input)
    {
        return input.Select(Parse)
            .Select(x => (s1: x.l * x.w, s2: x.w * x.h, s3: x.h * x.l))
            .Select(x => new[] { x.s1, x.s2, x.s3 }.Min() + 2 * (x.s1 + x.s2 + x.s3))
            .Sum();
    }

    public static int Part2(List<string> input)
    {
        return input.Select(Parse)
            .Select(x => (x.l * x.w * x.h, new[] { x.l, x.w, x.h }.OrderBy(y => y).Take(2).ToList()))
            .Select(x => x.Item1 + 2 * (x.Item2[0] + x.Item2[1]))
            .Sum();
    }

    private static (int l, int w, int h) Parse(string line)
    {
        var splitLine = line.Split('x');
        return (int.Parse(splitLine[0]), int.Parse(splitLine[1]), int.Parse(splitLine[2]));
    }
}