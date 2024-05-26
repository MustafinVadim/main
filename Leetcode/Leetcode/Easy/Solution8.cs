using System.Text;

namespace Easy;

public class Solution8
{
    public int MyAtoi(string s)
    {
        s = s.Trim();
        if (string.IsNullOrEmpty(s))
            return 0;

        var isNegative = s[0] == '-';
        var isNeedToSkip = isNegative || s[0] == '+';
        var builder = new StringBuilder(); 

        for (var i = isNeedToSkip ? 1 : 0; i < s.Length; i++)
        {
            if (!char.IsDigit(s[i]))
                break;

            builder.Append(s[i]);
        }

        var buildResult = builder.ToString();
        if (buildResult.Length == 0)
            return 0;

        if (int.TryParse(buildResult, out var result))
            return isNegative ? -result : result;

        return isNegative ? int.MinValue : int.MaxValue;
    }
}