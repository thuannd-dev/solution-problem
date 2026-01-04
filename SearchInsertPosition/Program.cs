public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++) if (nums[i] == target || nums[i] > target) return i;
        return nums.Length;
    }
}

class Program
{
    public static void Main()
    {
        int[] nums = { 1, 3, 5, 6 };
        Solution solution = new Solution();
        Console.WriteLine(solution.SearchInsert(nums, 7));
    }
}