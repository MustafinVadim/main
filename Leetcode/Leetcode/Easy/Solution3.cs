namespace Easy;

public class Solution3
{
    public int LengthOfLongestSubstring(string s)
    {
        var result = 0;
        var set = new HashSet<char>();
        
        for (var i = 0; i < s.Length; i++)
        {
            for (var j = i; j < s.Length; j++)
            {
                set.Add(s[j]);
                
                if (set.Count == j - i + 1)
                    continue;
                
                if (set.Count > result)
                {
                    result = set.Count;
                }
                    
                set.Clear();
                break;
            }

            if (set.Count > result)
                result = set.Count;
            
            set.Clear();
        }

        return result;
    }
}