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
        while (l1 is not null && l2 is not null){
            int sum = (l1.val + l2.val) % 10;
            itr.next = new ListNode(sum + carryOver);
            carryOver = (l1.val + l2.val) / 10;
            itr = itr.next;
            l1 = l1.next;
            l2 = l2.next;
        }
        
        while (l1 is not null){
            itr.next = new ListNode(l1.val);
            itr = itr.next;
            l1 = l1.next;
        }
    
        while (l2 is not null){
            itr.next = new ListNode(l2.val);
            itr = itr.next;
            l2 = l2.next;
        }
        
        return res.next;
    }
}