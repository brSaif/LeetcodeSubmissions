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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode sen = new ListNode(0, head);
        ListNode pred = sen;
        
        while (head is not null){
            if (head.next is not null && head.val == head.next.val) {
                while (head.next is not null && head.val == head.next.val){
                    head = head.next;
                }
                
                pred.next = head.next;
            }else{
                pred = pred.next;
            }
            
            head = head.next;
        }
        return sen.next;
    }
}