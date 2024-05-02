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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 is null) return list2;
        if (list2 is null) return list1;
        
        ListNode start = new ListNode(0), curr = start;
        
        while (list1 is not null &&
               list2 is not null){
            if (list1.val < list2.val){
                curr.next = list1;
                list1 = list1.next;
            }else{
                curr.next = list2;
                list2 = list2.next;
            }
            
            curr = curr.next;
        }
        
        while (list1 is not null){
            curr.next = list1;
            curr = curr.next;
            list1 = list1.next;
        }
        
         while (list2 is not null){
            curr.next = list2;
            curr = curr.next;
            list2 = list2.next;
        }
        
        return start.next;
    }
}