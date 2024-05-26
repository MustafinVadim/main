namespace Easy;

public class Solution5
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";

        var n = s.Length;
        var t = new char[2 * n + 1];
        for (var i = 0; i < n; i++)
        {
            t[2 * i] = '#';
            t[2 * i + 1] = s[i];
        }
        t[2 * n] = '#';

        var p = new int[2 * n + 1];
        int center = 0, right = 0;
        for (var i = 1; i < t.Length - 1; i++)
        {
            var mirror = 2 * center - i;
            if (i < right)
            {
                p[i] = Math.Min(right - i, p[mirror]);
            }

            while (i + p[i] + 1 < t.Length && i - p[i] - 1 >= 0 && t[i + p[i] + 1] == t[i - p[i] - 1])
            {
                p[i]++;
            }

            if (i + p[i] <= right)
                continue;
            
            center = i;
            right = i + p[i];
        }

        var maxLength = 0;
        var maxCenter = 0;
        for (var i = 0; i < p.Length; i++)
        {
            if (p[i] <= maxLength)
                continue;
            
            maxLength = p[i];
            maxCenter = i;
        }

        var start = (maxCenter - maxLength) / 2;
        return s.Substring(start, maxLength);
    }
}