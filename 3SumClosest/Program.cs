public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        if (nums.Length == 3)
        {
            return nums[0] + nums[1] + nums[2];
        }
        int distance = 999999999, result = 99999999;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int left = i + 1, right = nums.Length - 1;
            while (left < right)
            {
                int calculate = nums[i] + nums[left] + nums[right];
                if (calculate == target)
                {
                    return calculate;
                }
                if (Int32.Abs(calculate - target) < distance)
                {
                    result = calculate;
                    distance = Int32.Abs(calculate - target);
                }
                if (calculate < target)
                {
                    left++;
                }
                else if (calculate > target)
                {
                    right--;
                }
            }
        }
        return result;
    }
}

public class Program
{
    public static void Main()
    {
        Solution s = new Solution();
        Console.Write(s.ThreeSumClosest([-1, 2, 1, -4], 1));
    }
}