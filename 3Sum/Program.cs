public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = [];
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++)
        {
            //nếu tk từ vị trí số 1 trở đi giống tk trước thì next [0,0,0,0]
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            int left = i + 1, right = nums.Length - 1;
            while (left < right)
            {
                if (nums[i] + nums[left] + nums[right] == 0)
                {
                    result.Add([nums[i], nums[left], nums[right]]);
                    left++;
                    //dịch chuyển left đến vị trí có giá trị khác left hiện tại 
                    while (left < right && nums[left] == nums[left - 1])
                    {
                        left++;
                    }
                }
                else if (nums[i] + nums[left] + nums[right] > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }
        return result;
    }
}



public class Program
{
    public static void Main() 
    {  
        Solution s = new Solution();
        var x =  s.ThreeSum([-1, 0, 1, 2, -1, -4]);
        for(int i = 0; i < x.Count; i++)
        {
            Console.Write(x[i][0] + " ");
            Console.Write(x[i][1] + " ");
            Console.Write(x[i][2] + "\n");
        }
    }
}