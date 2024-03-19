namespace AoC;

public class Day1
{
    public static async Task Part1(IAsyncEnumerable<string?> data)
    {
        await foreach (var line in data)
        {
            Console.WriteLine(line);
        }
    }
}