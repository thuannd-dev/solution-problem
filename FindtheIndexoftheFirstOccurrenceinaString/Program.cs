public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        for(int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if(haystack.Substring(i, needle.Length) == needle)
            {
                return i;
            }
        }
        return -1;
    }
}

class Program
{
    public static void Main()
    {
        Solution s = new Solution();
        string haystack = "leetcode", needle = "leeto";
        Console.WriteLine(s.StrStr(haystack, needle));
    }
}