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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        if(l1.val <= l2.val)
        {
            return new ListNode(l1.val, MergeTwoLists(l1.next, l2));
        }
        else
        {
            return new ListNode(l2.val, MergeTwoLists(l1, l2.next));
        }
    }
}