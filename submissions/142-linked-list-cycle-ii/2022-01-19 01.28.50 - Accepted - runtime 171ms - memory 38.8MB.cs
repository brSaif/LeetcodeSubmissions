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
        var hs = new HashSet<ListNode>();
        
        var node = head;
        
        while(node != null){
            if(!hs.Add(node)) return node;
            
            node = node.next;
        }
        
        return null;
    }
}