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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 is null) return list2;
        if (list2 is null) return list1;
        
        if (list1.val <= list2.val)
            return new ListNode(list1.val, MergeTwoLists(list1.next, list2));
        else 
            return new ListNode(list2.val, MergeTwoLists(list2.next, list1));
    }
}