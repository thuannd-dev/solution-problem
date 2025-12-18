class Program
{
    public static void Main(string [] args)
    {
        //Input: list1 = [1,2,4], list2 = [1,3,4]
        //Output: [1, 1, 2, 3, 4, 4]
        ListNode list1 = new ListNode(1);
        ListNode list2 = null;
        Solution solution = new Solution();
        ListNode result = solution.MergeTwoLists(list1, list2);
        while(result != null)
        {
            Console.WriteLine(result.val);
            result = result.next;
        }
    }
}
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null) return null;
        ListNode result = null, current = result;
        if(list1.IsBigger(list2))
        {
            result = new ListNode(list2.val);
            current = result;
            list2 = list2.next;
        }else
        {
            result = new ListNode(list1.val);
            current = result;
            list1 = list1.next;
        }
        while(list1 != null && list2 != null)
        {
            if(list1.IsBigger(list2))
            {
                current.next = new ListNode(list2.val);
                current = current.next;
                list2 = list2.next;
            }else
            {
                current.next = new ListNode(list1.val);
                current = current.next;
                list1 = list1.next;
            }
        }
        while (list1 != null)
        {
            current.next = new ListNode(list1.val);
            current = current.next;
            list1 = list1.next;
        }
        while (list2 != null)
        {
            current.next = new ListNode(list2.val);
            current = current.next;
            list2 = list2.next;
        }
        return result;
    }

}

public static class ListNodeExtensions
{
    public static bool IsBigger(this ListNode list1, ListNode list2)
    {
        if (list1 == null) return true;
        if (list2 == null) return false;
        return list1.val > list2.val;
    }
}