class Program
{
    public static void Main (string[] args)
    {
        var head = new ListNode(1, new ListNode(2, null));
        Solution solution = new Solution();
        solution.RemoveNthFromEnd(head, 1);
        Console.WriteLine(solution.GetLength(head));
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {

        var current = head;
        int currentIndex = 1, length = GetLength(head), beforeNthFromEnd = length - n;
        if (beforeNthFromEnd == 0)
        {
            return head = head.next;
        }
        while (current.next != null)
        {
            if (currentIndex == beforeNthFromEnd)
            {
                current.next = current.next.next;
                return head;
            }
            current = current.next;
            currentIndex++;
        }
        return head;
    }

    public int GetLength(ListNode head)
    {
        int length = 1;
        var current = head;
        while (current.next != null)
        {
            current = current.next;
            length++;
        }
        return length;
    }
}