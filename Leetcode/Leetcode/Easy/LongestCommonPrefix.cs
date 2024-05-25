using System.Text;

namespace Easy;

public class LongestCommonPrefixSolution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var shortestArray = strs.MinBy(s => s.Length);

        if (shortestArray is null)
            return "";

        var builder = new StringBuilder();

        for (var i = 0; i < shortestArray.Length; i++)
        {
            var symbol = shortestArray[i];
            if (strs.All(s => s[i] == symbol))
                builder.Append(symbol);
            else
                break;
        }

        return builder.ToString();
    }
}