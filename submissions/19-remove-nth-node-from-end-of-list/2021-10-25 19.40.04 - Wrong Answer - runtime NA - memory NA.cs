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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        ListNode slow = head, fast = head;
        while(n > 0){
            if(fast.next is null) break;
            fast = fast.next;
            n--;
        }
        
        while(fast.next != null){
            fast = fast.next;
            slow = slow.next;
        }
        
        if(slow.next != null) slow.next = slow.next.next;
        else head = null;
        return head;
        
    }
}