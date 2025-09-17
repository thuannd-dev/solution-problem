public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (CheckPalindrome(s))
        {
            return s;
        }
        var arrChar = s.ToCharArray();
        string result = arrChar[0].ToString();
        for (int i = 0; i < arrChar.Length - 1; i++)
        {
            string tmp = arrChar[i].ToString();
            for (int j = i + 1; j < arrChar.Length; j++)
            {
                //tmp = string.Concat(tmp, arrChar[j]);
                tmp = tmp + arrChar[j];
                if (CheckPalindrome(tmp) && tmp.Length > result.Length)
                {
                    result = tmp;
                }
            }
        }
        return result;
    }

    public Boolean CheckPalindrome(string s)
    {
        var arrChar = s.ToCharArray();
        var lengthOfArrChar = arrChar.Length;
        for (int i = 0; i < lengthOfArrChar / 2; i++)
        {
            if (arrChar[i] != arrChar[lengthOfArrChar - i - 1]) return false;
        }
        return true;

    }
}

class Program
{
    static void Main(string[] args)
    {
        var s = new Solution();
        Console.WriteLine(s.CheckPalindrome("aaaa"));
    }
}