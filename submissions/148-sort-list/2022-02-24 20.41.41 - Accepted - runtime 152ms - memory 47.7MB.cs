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
     public ListNode SortList(ListNode head) 
      => Traverse(head)
            .OrderBy(a => a.val)
            .Reverse()
            .Aggregate<ListNode, ListNode>(null, (a, b) => 
                                           new ListNode(b.val, a));
    
    private IEnumerable<ListNode> Traverse(ListNode head)
    {
        while (head != null)
        {
            yield return head;
            head = head.next;
        }
        yield break;
    }
}