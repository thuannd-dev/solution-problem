public class Solution
{
    public int Divide(int dividend, int divisor)
    {
        try { return dividend / divisor; } catch (Exception e) { return (dividend < 0 && divisor < 0 || dividend > 0 && divisor > 0) ? Int32.MaxValue : Int32.MinValue; }
    }
}

class Program
{
    public static void Main()
    {
        Solution s = new Solution();
        int dividend = -2147483648, divisor = -1;
        Console.WriteLine(s.Divide(dividend, divisor));
    }
}