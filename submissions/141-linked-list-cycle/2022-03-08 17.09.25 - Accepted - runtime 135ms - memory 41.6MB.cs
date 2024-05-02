/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
     
        if (head is null || head.next is null) return false;
        
        while (head.val != Int32.MinValue){
            head.val = int.MinValue;
            if (head.next is null) return false;
            head = head.next;
        }
        return true;
    }
}