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
public class Solution {
    public ListNode MergeTwoLists(ListNode l, ListNode n) {
        if (l is null) return n;
        if (n is null) return l;
        
        if(l.val <= n.val)
            return new ListNode(l.val, MergeTwoLists(l.next, n));
        else
            return new ListNode(n.val, MergeTwoLists(n.next, l));
    }
}