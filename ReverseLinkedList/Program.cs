/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

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
    public ListNode ReverseList(ListNode head)
    {
        ListNode current = head;
        Stack<int> st = new Stack<int>();
        while (current != null)
        {
            st.Push(current.val);
            current = current.next;
        }
        current = head;
        while (current != null)
        {
            current.val = st.Pop();
            current = current.next;
        }
        return head;
    }

}