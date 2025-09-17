//public class Solution
//{
//    public string Convert(string s, int numRows)
//    {
//        if (numRows == 1)
//        {
//            return s;
//        }
//        var charArr = s.ToCharArray();
//        string result = "";
//        //tim ky tu cua tung row
//        for (int i = 0; i < numRows; i++)
//        {
//            int line = 0;
//            Boolean flagReverse = false;
//            for (int j = 0; j < charArr.Length; j++)
//            {
//                if (line == i)
//                {
//                    result = result + charArr[j];
//                }
//                if (line < numRows - 1 && !flagReverse)
//                {
//                    line++;
//                }
//                else
//                {
//                    flagReverse = true;
//                    //>=
//                    if (line == 1)
//                    {
//                        flagReverse = false;
//                        line = 0;
//                    }
//                    else
//                    {
//                        line--;
//                    }
//                }
//            }
//        }
//        return result;
//    }
//}
public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }
        var charArr = s.ToCharArray();
        Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
        for (int i = 0; i < numRows; i++)
        {
            keyValuePairs.Add(i, "");
        }

        int line = 0;
        Boolean flagReverse = false;
        for (int j = 0; j < charArr.Length; j++)
        {
            keyValuePairs[line] = keyValuePairs[line] + charArr[j];
            if (line < numRows - 1 && !flagReverse)
            {
                line++;
            }
            else
            {
                flagReverse = true;
                //>=
                if (line == 1)
                {
                    flagReverse = false;
                    line = 0;
                }
                else
                {
                    line--;
                }
            }
        }
        string result = "";
        for (int i = 0; i < numRows; i++)
        {
            result += keyValuePairs[i];
        }
        return result;
    }
}

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.Write(solution.Convert("PAYPALISHIRING", 3));
    }
}