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
    public ListNode SwapNodes(ListNode head, int k) {
        ListNode  l1, l2, slow = head, fast = new(0, head);
        while (k-- > 0){
            if (fast is not null && fast.next is not null)
                fast = fast.next;
        }
        
        l1 = fast;
        
        while (fast is not null && fast.next is not null){
            fast = fast.next;
            slow = slow.next;
        }
        
        l2 = slow;
        
        int tmp = l1.val;
        l1.val = l2.val;
        l2.val = tmp;
        
        return head;
    }
}