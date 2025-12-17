class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.IsValid("(("));
    }
}

//public class Solution
//{
//    public bool IsValid(string s)
//    {
//        var arrChar = s.ToCharArray();
//        if(arrChar.Length % 2 != 0)  return false; 
//        Stack<char> stack = new Stack<char>();
//        stack.Push(arrChar[0]);
//        for(int i = 1; i < arrChar.Length; i++)
//        {
//            if(!stack.TryPeek(out char above))
//            {
//                stack.Push(arrChar[i]);
//                above = arrChar[i];
//                i++;
//            }
//            var next = arrChar[i];
//            if (IsCoupleOfCharValid(above, next))
//            {
//                stack.Pop();
//            }else
//            {
//                stack.Push(next);
//            }
//        }
//        if (stack.Count == 0) return true;
//        return false;

//    }

//    public bool IsCoupleOfCharValid(char above, char below)
//    {
//        if(above == '(' && below == ')') return true;
//        else if (above == '[' && below == ']') return true;
//        else if (above == '{' && below == '}') return true;
//        else return false;
//    }

//}

public class Solution
{
    public bool IsValid(string s)
    {
        var arrChar = s.ToCharArray();
        if (arrChar.Length % 2 != 0) return false;
        Stack<char> stack = new Stack<char>();
        foreach (var c in arrChar)
        {
            if (c == '(')
            {
                stack.Push(')');
            }
            else if (c == '[')
            {
                stack.Push(']');
            }
            else if (c == '{') 
            {
                stack.Push('}');
            }else if (stack.Count == 0 || stack.Pop() != c)
            {
                return false;
            }
        }
        return stack.Count == 0;
    }

}