/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        ListNode curr = node;
        if(curr.next != null){
            curr.val = curr.next.val;
            curr.next = curr.next.next;
            node = curr;
            curr = null;
        }
        
        GC.Collect();
        return;
    }
}