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
        ListNode tmpL = new ListNode();
        ListNode curr = tmpL;
        
        int carry = 0;
        while(l1 is not null 
              || l2 is not null 
              || carry > 0){
            int v1, v2, v3;
            v1 = (l1 is not null) ? l1.val : 0;
            v2 = (l2 is not null) ? l2.val : 0;
            v3 = v1 + v2 + carry;
            
            carry = v3 / 10;
            v3 %= 10;
            
            curr.next = new ListNode(v3);
            
            curr  = curr.next;
            l1 = (l1 is not null) ? l1.next : null;
            l2 = (l2 is not null) ? l2.next : null;
        }
        
        return tmpL.next;
        
    }
}