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

    Random rnd = new Random();
    ListNode head;
    int Count = 0;
    public Solution(ListNode head) {
        this.head = head;
        
        for(var node = head; node != null; node = node.next)
            Count++;    
    }
    
    public int GetRandom() {
        int c = rnd.Next(0,Count);
        
        var tmp = head;
        for(int i = 0; i < c; i++){
            tmp = tmp.next;
        }
        return tmp.val;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */