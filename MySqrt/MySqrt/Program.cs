public class Solution
{
    public int MySqrt(int x)
    {
        //int pow = 1;
        //while (pow * pow <= x)
        //{
        //    pow++;
        //}
        //return pow - 1;
        return (int)Math.Sqrt(x);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int x = 4;
        int result = solution.MySqrt(x);
        Console.WriteLine(result); // Output: 2
    }
}