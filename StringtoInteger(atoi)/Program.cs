using System.Text.RegularExpressions;

public class Solution
{
    public int MyAtoi(string s)
    {
        s = s.Trim();
        if (s == "")
        {
            return 0;
        }
        var arrChar = s.ToCharArray();
        int i;
        if (!((arrChar[0] == '-' && arrChar.Length >= 2 && arrChar[1] != '+') ||
                (arrChar[0] == '+' && arrChar.Length >= 2 && arrChar[1] != '-')))
        {
            return 0;
        }
        for (i = 1; i < arrChar.Length; i++)
        {
            if (!(arrChar[i] >= '0' && arrChar[i] <= '9'))
            {
                break;
            }
        }
        var stringResult = "";
        for (int j = 0; j < i; j++)
        {
            stringResult += arrChar[j];
        }
        Int32.TryParse(stringResult, out var result);
        if (Regex.IsMatch(s, @"0000+") && result == 0)
        {
            return 0;
        }
        if (result == 0 && arrChar[0] == '-' && stringResult != "0" && stringResult != "")
        {
            return int.MinValue;
        }
        if (result == 0 && stringResult != "0" && stringResult != "")
        {
            return int.MaxValue;
        }
        return result;
    }
}

public class Program
{
    public static void Main()
    {
        Solution s = new Solution();
        Console.WriteLine(s.MyAtoi("  -0012a42"));
    }
}