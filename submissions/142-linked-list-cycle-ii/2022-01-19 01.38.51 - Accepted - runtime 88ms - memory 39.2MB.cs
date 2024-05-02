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
    public ListNode DetectCycle(ListNode head) {
        ListNode fast = head;
        ListNode slow = head;
        bool loopDetected = false;
        
        while (fast != null && fast.next != null) {
            fast = fast.next.next;
            slow = slow.next;
            
            if (fast == slow) {
                loopDetected = true;
                break;
            }
        }
        
        if (!loopDetected) {
            return null;
        }
        
        ListNode secondRunner = head;
        
        while (secondRunner != fast) {
            secondRunner = secondRunner.next;
            fast = fast.next;
        }
        
        return secondRunner;
    }
}