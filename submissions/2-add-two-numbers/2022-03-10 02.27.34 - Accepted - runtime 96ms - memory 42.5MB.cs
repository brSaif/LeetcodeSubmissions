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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode res = new ListNode();
        ListNode itr = res;
        int carryOver = 0;
        while (l1 is not null || l2 is not null || carryOver > 0){
            int v1 = (l1 is null) ? 0 : l1.val;
            int v2 = (l2 is null) ? 0 : l2.val;
            int v3 = v1 + v2 + carryOver;
            
            carryOver = v3 / 10;
            v3 %= 10;
            
            itr.next = new ListNode(v3);
            itr = itr.next;
            
            l1 = (l1 is null) ? null : l1.next;
            l2 = (l2 is null) ? null : l2.next;
        }
        
        return res.next;
    }
}