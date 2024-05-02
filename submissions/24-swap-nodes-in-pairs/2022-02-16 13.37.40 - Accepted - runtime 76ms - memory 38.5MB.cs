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
    public ListNode SwapPairs(ListNode head) {
        if (head is null || head.next is null) return head;
        ListNode s = head, f = head.next;
        while(f != null){
            var tmp = s.val;
            s.val = f.val;
            f.val = tmp;
            
            if(f is null || f.next is null) break;
            
            s = s.next.next;
            f = f.next.next;
        }
        return head;
    }
}