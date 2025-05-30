class Solition
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
            if (charSet.Contains(chars[i])) {
                i = ++index;
                if (charSet.Count > maxLengthResult)
                {
                    maxLengthResult = charSet.Count;
                }
                charSet.Clear();
                charSet.Add(chars[i]);
            }else
            {
                charSet.Add(chars[i]);
            }
        }
        return charSet.Count > maxLengthResult ? charSet.Count : maxLengthResult;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solition solution = new Solition();
        var s = "abcabcbb";
        Console.WriteLine(solution.LengthOfLongestSubstring(s));
    }
}