namespace Easy;

public class Solution7
{
    public int Reverse(int x)
    {
        var isNegative = x < 0;
        if (isNegative)
            x = -x;
        var asString = x.ToString();
        var reversedString = new string(asString.Reverse().ToArray());

        return int.TryParse(reversedString, out var result) ? isNegative ? -result : result : 0;
    }
}