public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] tmpArr = new int[nums1.Length + nums2.Length];
        nums1.CopyTo(tmpArr, 0);
        nums2.CopyTo(tmpArr, nums1.Length);
        Array.Sort(tmpArr);
        int index = tmpArr.Length / 2;
        if (tmpArr.Length % 2 == 0)
        {
            return (tmpArr[index - 1] + tmpArr[index]) / 2.0;
        }
        else
        {
            return tmpArr[index];
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var solution = new Solution();
        int[] nums1 = [1, 2];
        int[] nums2 = [3, 4];
        double result = solution.FindMedianSortedArrays(nums1, nums2);
        Console.WriteLine(result); // Output: 2.0
    }
}