public class Solution
{
    public string AddBinary(string a, string b)
    {
        int lengthA = a.Length - 1;
        int lengthB = b.Length - 1;
        string ans = "";
        int carry = 0;
        while (lengthA >= 0 || lengthB >= 0 || carry > 0)
        {
            if (lengthA >= 0)
            {
                carry += a[lengthA] - '0';
                lengthA--;
            }
            if (lengthB >= 0)
            {
                carry += b[lengthB] - '0';
                lengthB--;
            }
            ans = (carry % 2) + ans;
            carry = carry / 2;
        }
        return ans;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string a = "1010";
        string b = "1011";
        string result = solution.AddBinary(a, b);
        Console.WriteLine(result); // Output: "10101"
    }
}