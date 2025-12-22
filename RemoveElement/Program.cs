public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int[] numsTemp = new int[nums.Length];
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                numsTemp[result] = nums[i];
                result++;
            }
        }
        for (int i = 0; i < result; i++)
        {
            nums[i] = numsTemp[i];
        }
        return result;
    }
}
class Program
{
    public static void Main()
    {
        int[] nums = [3, 2, 2, 3];
        Solution solution = new Solution();
        int result = solution.RemoveElement(nums, 3);
        Console.WriteLine(result);
        Console.WriteLine("----------------");
        for (int i = 0; i < result; i++) { 
            Console.WriteLine(nums[i]);
        }
    }
}