namespace Easy;

public class Solution125
{
    public bool IsPalindrome(string s)
    {
        var cleanString = string.Join("", s.Where(x => char.IsLetter(x) || char.IsDigit(x)).Select(char.ToLower));

        var leftIndex = 0;
        var rightIndex = cleanString.Length - 1;
        
        while (leftIndex < rightIndex)
        {
            var left = cleanString[leftIndex];
            var right = cleanString[rightIndex];
                
            if (left != right)
                return false;

            leftIndex += 1;
            rightIndex -= 1;
        }

        return true;
    }
}