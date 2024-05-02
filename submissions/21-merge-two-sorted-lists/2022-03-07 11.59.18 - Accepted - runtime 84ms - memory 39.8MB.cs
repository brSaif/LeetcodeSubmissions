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
    public ListNode MergeTwoLists(ListNode lst1, ListNode lst2) {
        if (lst1 is null) return lst2;
        if (lst2 is null) return lst1;
        
        ListNode  res = new ListNode(0), curr = res;
        
        while (lst1 is not null && 
               lst2 is not null){
            if (lst1.val < lst2.val){
                curr.next = lst1;
                lst1 =  lst1.next;
            }else
            {
                curr.next = lst2;
                lst2 = lst2.next;
            }
            curr = curr.next;
        }
        
        while (lst1 is not null){
            curr.next = lst1;
            curr = curr.next;
            lst1 = lst1.next;
        }
        
         while (lst2 is not null){
            curr.next = lst2;
            curr = curr.next;
            lst2 = lst2.next;
        }
        
        return res.next;
        
    }
}