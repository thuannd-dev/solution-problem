public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0)
        {
            return [];
        }
        IList<string> result = [];
        string[][] value = new string[10][];
        value[2] = new string[] { "a", "b", "c" };
        value[3] = new string[] { "d", "e", "f" };
        value[4] = new string[] { "g", "h", "i" };
        value[5] = new string[] { "j", "k", "l" };
        value[6] = new string[] { "m", "n", "o" };
        value[7] = new string[] { "p", "q", "r", "s" };
        value[8] = new string[] { "t", "u", "v" };
        value[9] = new string[] { "w", "x", "y", "z" };
        char[] digit = digits.ToCharArray();
        if (digits.Length == 1)
        {
            return value[digits[0] - '0'];
        }
        int[] nums = new int[digit.Length];
        for (int i = 0; i < digit.Length; i++)
        {
            nums[i] = digit[i] - '0';
        }
        if (nums.Length == 2)
        {
            for (int i = 0; i < value[nums[0]].Length; i++)
            {
                string current = value[nums[0]][i];
                for (int j = 0; j < value[nums[1]].Length; j++)
                {
                    result.Add(current + value[nums[1]][j]);
                }
            }
            return result;
        }

        if (nums.Length == 3)
        {
            for (int i = 0; i < value[nums[0]].Length; i++)
            {
                string current = value[nums[0]][i];
                for (int j = 0; j < value[nums[1]].Length; j++)
                {
                    current = value[nums[0]][i] + value[nums[1]][j];
                    for (int k = 0; k < value[nums[2]].Length; k++)
                    {
                        result.Add(current + value[nums[2]][k]);
                    }
                }
            }
            return result;
        }


        for (int i = 0; i < value[nums[0]].Length; i++)
        {
            string current = value[nums[0]][i];
            for (int j = 0; j < value[nums[1]].Length; j++)
            {
                current = value[nums[0]][i] + value[nums[1]][j];
                for (int k = 0; k < value[nums[2]].Length; k++)
                {
                    current = value[nums[0]][i] + value[nums[1]][j] + value[nums[2]][k];
                    for (int g = 0; g < value[nums[3]].Length; g++)
                    {
                        result.Add(current + value[nums[3]][g]);
                    }
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
        s.LetterCombinations("23");
    }
}