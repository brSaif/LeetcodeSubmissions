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
    public bool IsPalindrome(ListNode head) {
        var list = new List<int>();
        ListNode node = head, next = null;
        if(head.next == null) return true;
        while(node.next != null){
            list.Add(node.val);
            next = node.next;
            node = next;
        }
        
        list.Add(node.val);
        
        var arr = list.ToArray();
        var str1 =  String.Join(' ',arr);
        Console.WriteLine(str1);
        Array.Reverse(arr);
        var str2 =  String.Join(' ',arr);
        Console.WriteLine(str2);
        return str1 == str2;
    }
}