public class Solution
{
    public int MaxArea(int[] height)
    {
        int result = 0;
        // for(int i = 0; i < height.Length - 1; i++) {
        //     for(int j = i + 1; j < height.Length; j++) {
        //         int amountOfWater = (j - i) * MinHeight(height[i], height[j]);
        //         if(amountOfWater > result) {
        //             result = amountOfWater;
        //         }
        //     }
        // }
        // return result;
        int i = 0, j = height.Length - 1;
        while (i != j)
        {
            int area = FindArea(height, i, j);
            if (area > result)
            {
                result = area;
            }
            if (height[i] > height[j])
            {
                j--;
            }
            else
            {
                //j > i
                i++;
            }
        }
        return result;
    }

    public int MinHeight(int a, int b)
    {
        return a > b ? b : a;
    }

    public int FindArea(int[] height, int position1, int position2)
    {
        return (position2 - position1) * MinHeight(height[position1], height[position2]);
    }
}

public class Program
{
    public static void Main()
    {
        Solution s = new Solution();
        Console.WriteLine(s.MaxArea([8, 7, 2, 1]));
    }
}