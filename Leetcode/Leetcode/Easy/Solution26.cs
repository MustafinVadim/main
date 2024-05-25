namespace Easy;

public class Solution26
{
    public int RemoveDuplicates(int[] nums)
    {
        var list = nums.ToHashSet().OrderBy(x => x).ToList();

        for (var i = 0; i < list.Count; i++)
        {
            nums[i] = list[i];
        }

        return list.Count;
    }
}