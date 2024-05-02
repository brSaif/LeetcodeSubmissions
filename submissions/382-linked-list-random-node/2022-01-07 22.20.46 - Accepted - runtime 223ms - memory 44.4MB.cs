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

    ListNode head;
    ListNode cur;
    Random random = new Random();
    public Solution(ListNode head) {
        this.head = cur = head;
        
    }
    
    public int GetRandom() {
        
        //Console.WriteLine(cur.val);
        var i = random.Next(4);
        
        while(i > 0)
        {          
            i--;
            cur = cur.next;            
            if (cur == null)
                cur = head;            
        }
        
        return cur.val;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */