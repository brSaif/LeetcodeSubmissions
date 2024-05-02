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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode res = new ListNode(0, head);
        ListNode itr = res;
        while (head is not null){
            if (head.next is not null && head.val == head.next.val){
                while (head.next is not null && head.val == head.next.val){
                    head = head.next;
                }
                itr.next = head.next;
            }else
                itr = itr.next;
            head = head.next;
        }
        return res.next;
    }
}