namespace Easy;

public class Solution66
{
    public int[] PlusOne(int[] digits)
    {
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            var sum = digits[i] + 1;

            if (sum < 10)
            {
                digits[i] = sum;
                return digits;
            }

            digits[i] = 0;
            
            if (i == 0)
            {
                return new[] { 1 }.Concat(digits).ToArray();
            }
        }

        return digits;
    }
}