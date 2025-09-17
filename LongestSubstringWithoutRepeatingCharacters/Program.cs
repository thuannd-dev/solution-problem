class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if(s.Equals(""))
        {
            return 0;
        }
        var chars = s.ToCharArray();
        HashSet<char> charSet = new HashSet<char>();
        charSet.Add(chars[0]);
        int maxLengthResult = 1;
        int index = 0;
        for (int i = 1; i < chars.Length; i++)
        {
            if (charSet.Count > maxLengthResult)
            {
                maxLengthResult = charSet.Count;
            }
            if (charSet.Contains(chars[i])) {
                i = ++index;
                charSet.Clear();
            }
            charSet.Add(chars[i]);
            
        }
        return charSet.Count > maxLengthResult ? charSet.Count : maxLengthResult;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        var s = "dvdf";
        Console.WriteLine(solution.LengthOfLongestSubstring(s));
    }
}