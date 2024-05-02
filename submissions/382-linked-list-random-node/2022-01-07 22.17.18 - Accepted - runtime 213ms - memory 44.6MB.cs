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

    private ListNode _head;
    private Random _random;
    
    public Solution(ListNode head) {
        _head = head;
        _random = new Random();
    }
    
    /** Returns a random node's value. */
    public int GetRandom() {
        ListNode current = _head;
        ListNode randomNode = current;
        int count = 1;
        while (current.next != null) {
            current = current.next;
            if (_random.Next(++count) == 0)
                randomNode = current;
        }
        return randomNode.val;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */