public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        /*
         1-> 2 -> 3 -> 4 -> 5 -> 6
         2-> 1 -> 3 -> 4 -> 5 -> 6

        b1: 1 -> 4   =>>> mat lien ket voi 3 => luu 3 lai 
        b2: 4 -> 3  =>>> mat lien ket voi 5 => luu 5 lai
        b3: 3 -> 5
         2-> 1 -> 4 -> 3 -> 5 -> 6
        b4: set current lai  = 3

        lap lai cho toi khi tk current.next != null
         2-> 1 -> 4 -> 3 -> 6 -> 5
         */
        if (head == null || head.next == null)  return head;
        ListNode result = head.next;
        ListNode current = head;
        current.next = current.next.next;
        result.next = current;
        while (current.next != null)
        {
            if(current.next.next == null) return result;
            ListNode nodeNextCurrent = current.next, nodeTwoFromCurrent = current.next.next,
                nodeThreeFromCurrent = current.next.next.next;
            //1 -> 4
            current.next = nodeTwoFromCurrent;
            nodeTwoFromCurrent.next = nodeNextCurrent;
            nodeNextCurrent.next = nodeThreeFromCurrent;
            current = nodeNextCurrent;
        }
        return result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ListNode listNode = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        Solution solution = new Solution();
        ListNode result = solution.SwapPairs(listNode);
        while (result != null) { 
            Console.WriteLine(result.val);
            result = result.next;

        }
    }
}