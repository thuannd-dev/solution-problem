using System.Diagnostics;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        return s.TrimEnd().Split(' ').Last().Length;
    }
}

class Program
{
    public static void Main()
    {
        Solution s = new Solution();
        var a = "   fly me   to   the moon  ";
        Console.WriteLine(s.LengthOfLastWord(a));
    }
}