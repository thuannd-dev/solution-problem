/*
 This is a demo task.

Write a function:

class Solution { public int solution(int[] A); }
content_copy

that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

Given A = [1, 2, 3], the function should return 4.

Given A = [−1, −3], the function should return 1.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..100,000];
each element of array A is an integer within the range [−1,000,000..1,000,000].
Copyright 2009–2025 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited. 
 */
class Solution
{
    public int solution(int[] A)
    {
        // Implement your solution here
        Array.Sort(A);
        int result = 1;
        for (int i = 0; i < A.Length; i++)
        {
            if (result == A[i])
            {
                result++;
            }
        }
        return result;
    }
}
class Program
{
    static void Main(string[] args)
    {
        var s = new Solution();
        Console.WriteLine(s.solution([-1, -3]));
    }
}