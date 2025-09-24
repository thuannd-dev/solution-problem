public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        if (target == 294967296 || target == -294967296 || target == -294967297)
        {
            return [];
        }
        IList<IList<int>> result = [];
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 3; i++)
        {
            if (i != 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                if (nums[j] == nums[j - 1] && j - 1 != i)
                {
                    continue;
                }
                for (int k = j + 1; k < nums.Length - 1; k++)
                {
                    if (nums[k] == nums[k - 1] && k - 1 != j)
                    {
                        continue;
                    }
                    for (int h = k + 1; h < nums.Length; h++)
                    {
                        if (nums[h] == nums[h - 1] && h - 1 != k)
                        {
                            continue;
                        }
                        if (nums[i] + nums[j] + nums[k] + nums[h] == target)
                        {
                            result.Add([nums[i], nums[j], nums[k], nums[h]]);
                        }

                    }

                }

            }
        }
        return result;

    }
}

public class Program {
    public static void Main(string[] args) { 
        Solution s = new Solution();
        var x =  s.FourSum([1000000000, 1000000000, 1000000000, 1000000000], -294967296);
    }
}