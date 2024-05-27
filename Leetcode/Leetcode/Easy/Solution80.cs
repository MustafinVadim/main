namespace Easy;

public class Solution80
{
    public int RemoveDuplicates(int[] nums)
    {
        var dictionary = new Dictionary<int, int>();
        var current = 0;

        foreach (var num in nums)
        {
            if (!dictionary.TryAdd(num, 1))
                dictionary[num] += 1;
            
            if (dictionary[num] > 2)
                continue;

            nums[current] = num;
            current += 1;
        }

        return current;
    }
}