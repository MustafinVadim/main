namespace AoC;

public class Day5
{
    public static int Part1(List<string> input)
    {
        return input.Where(HasThreeVowels)
            .Where(HasDoubleLetters)
            .Where(NotContainsStopWords)
            .Count();
    }

    public static int Part2(List<string> input)
    {
        return input.Where(HasOneByOneLetters)
            .Where(HasPairs)
            .Count();
    }

    private static bool HasThreeVowels(string word) => word.Count(x => "aeiou".Contains(x)) > 2;
    
    private static bool HasDoubleLetters(string word) => word.Zip(word.Skip(1), (a, b) => a == b).Any(x => x);
    
    private static bool NotContainsStopWords(string word) => !new[] { "ab", "cd", "pq", "xy" }.Where(word.Contains).Any();
    
    private static bool HasOneByOneLetters(string word) => word.Zip(word.Skip(2), (a, b) => a == b).Any(x => x);

    private static bool HasPairs(string word)
    {
        var pairs = word.Zip(word.Skip(1), (a, b) => a.ToString() + b).ToList();
        
        for (var i = 0; i < pairs.Count; i++)
            for (var j = i + 2; j < pairs.Count; j++)
                if (pairs[i] == pairs[j])
                    return true;

        return false;
    }
}