namespace Easy;

public class Solution28
{
    public int StrStr(string haystack, string needle)
    {
        var spl = haystack.Split(needle);
        return spl.Length == 0 || spl[0].Length == haystack.Length ? -1 : spl[0].Length;
    }
}