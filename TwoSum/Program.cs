class Solution
{
    public int[] TwoSumV1(int[] nums, int target)
    {
        for(int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (j == i) continue;
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }
        return [];
    }
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if(numMap.ContainsKey(complement))
            {
                return [numMap.GetValueOrDefault(complement), i];
            }
            numMap.TryAdd(nums[i], i);
        }
        return [];
    }
}

class Program
{
    public static void Main(string[] args)
    {
        int[] nums = [1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1];
        int target = 11;
        Solution solution = new Solution();
        int[] result = solution.TwoSum(nums, target);
        Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
    }
}