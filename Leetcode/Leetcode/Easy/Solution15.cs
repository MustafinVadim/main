namespace Easy;

public class Solution15
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (nums == null || nums.Length < 3)
        {
            return result;
        }

        Array.Sort(nums);

        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            var left = i + 1;
            var right = nums.Length - 1;
            var target = -nums[i];

            while (left < right)
            {
                var sum = nums[left] + nums[right];
                if (sum == target)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1])
                    {
                        left++;
                    }

                    while (left < right && nums[right] == nums[right + 1])
                    {
                        right--;
                    }
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result;
    }
}