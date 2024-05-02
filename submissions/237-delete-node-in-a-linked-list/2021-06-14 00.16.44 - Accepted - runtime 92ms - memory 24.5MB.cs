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
        ListNode temp = node;
        ListNode nextNode = node.next;
        if(temp.next != null){
            temp.val = temp.next.val;
            temp.next = temp.next.next;
            node = temp;
            temp = null;
        }
 
        // Free memory
        GC.Collect();
 
        return;
    }
}