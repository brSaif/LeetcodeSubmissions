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
    public ListNode SortList(ListNode head) {
        return MergeSort(head);
    }
    
    private ListNode MergeSort(ListNode l)
    {
        if (l == null || l.next == null)
            return l;
        
        ListNode n1 = l,
                 n2 = l.next,
                 n3 = null;
        
        while (n2 != null)
        {
            if (n2.next != null)
                n2 = n2.next.next;
            else
                n2 = null;

            if (n2 != null)
                n1 = n1.next;
        }

        n3 = n1.next;
        n1.next = null;
        
        ListNode n4 = MergeSort(l),
                 n5 = MergeSort(n3);
        
        return Merge(n4, n5);
    }
    
    private ListNode Merge(ListNode l1, ListNode l2)
    {
        ListNode dummy = new ListNode(),
                 cur = dummy;
        
        while (l1 != null && l2 != null)
        {
            if (l1.val <= l2.val)
            {
                cur.next = l1;
                l1 = l1.next;
            }
            else
            {
                cur.next = l2;
                l2 = l2.next;
            }
            
            cur = cur.next;
        }
        
        if (l1 != null)
            cur.next = l1;
        
        if (l2 != null)
            cur.next = l2;
        
        return dummy.next;
    }
}