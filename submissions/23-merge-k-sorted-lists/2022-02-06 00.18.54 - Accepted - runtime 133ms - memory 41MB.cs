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
    public ListNode MergeKLists(ListNode[] lists)
        {            
             if (lists == null)
                return null;

            var ss = new SortedSet<(int Value, int Index, ListNode Node)>();
            for (int i = 0; i < lists.Length; i++)
                if (lists[i] != null)
                    ss.Add((lists[i].val, i, lists[i]));

            ListNode head = new ListNode(), tail = head;
            while (ss.Count > 0) {
                var min = ss.Min;
                ss.Remove(min);

                tail.next = min.Node;
                tail = tail.next;

                var next = min.Node.next;
                if (next != null)
                    ss.Add((next.val, min.Index, next));
            }
            return head.next;
        }
}