namespace Easy;

public class Solution209
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        if (nums.Length == 0)
            return 0;
        
        
        var sum = nums.Sum();

        if (sum < target)
            return 0;

        if (sum == target)
            return nums.Length;

        var left = 0;
        var right = nums.Length - 1;
        var result = nums.Length;

        do
        {
            if (nums[left] < nums[right])
            {
                sum -= nums[left];
                left += 1;
            }
            else
            {
                sum -= nums[right];
                right -= 1;
            }
            
            if (sum < target)
                return result;
            
            result -= 1;
        } while (left < right);

        return result;
    }
}