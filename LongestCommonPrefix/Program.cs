public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        // var arrChar = strs[0].ToCharArray();
        // string result = "";
        // for (int i = 0; i < arrChar.Length; i++)
        // {
        //     for (int j = 1; j < strs.Length; j++)
        //     {
        //         if (i >= strs[j].Length || strs[j].ElementAt(i) != arrChar[i])
        //         {
        //             return result;
        //         }
        //     }
        //     result += arrChar[i];
        // }
        // return result;

        // string result = "";
        // for (int i = 0; i < strs[0].Length; i++)
        // {
        //     for (int j = 1; j < strs.Length; j++)
        //     {
        //         if (i >= strs[j].Length || strs[j].ElementAt(i) != strs[0].ElementAt(i))
        //         {
        //             return result;
        //         }
        //     }
        //     result += strs[0].ElementAt(i);
        // }
        // return result;

        Array.Sort(strs);
        int last = strs.Length - 1;
        string result = "";
        for (int i = 0; i < strs[0].Length; i++)
        {
            char tmp = strs[0].ElementAt(i);
            if (tmp != strs[last].ElementAt(i))
            {
                return result;
            }
            else
            {
                result += tmp;
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
        Console.WriteLine(s.LongestCommonPrefix(["ab", "a"]));
    }
}