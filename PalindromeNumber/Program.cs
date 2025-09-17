public class Solution
{
    public bool IsPalindrome(int x)
    {

        //var arrChar = x.ToString().ToCharArray();
        //for (int i = 0; i < arrChar.Length / 2; i++)
        //{
        //    if (arrChar[i] != arrChar[arrChar.Length - i - 1])
        //    {
        //        return false;
        //    }
        //}
        //return true;
        int reverseNumber = 0, tmp = x;
        while (x > 0) 
        {
            reverseNumber = reverseNumber * 10 + x % 10;
            x /= 10;
        }
        return reverseNumber == tmp;
    }
}

public class Program
{
    public static void Main()
    {
        Solution s = new Solution();
        Console.WriteLine(s.IsPalindrome(121));
    }

}