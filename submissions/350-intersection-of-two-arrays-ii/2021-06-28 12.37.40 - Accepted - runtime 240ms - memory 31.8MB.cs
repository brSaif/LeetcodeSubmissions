public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        
        var list = new List<int>();
        // Base Cases
        if(nums1.Length == 0 || nums2.Length ==0) return new int[1];
        // Sort Both Arrays
        Array.Sort(nums1);
        Array.Sort(nums2);
        // FIFO 
        Queue<int> nums1q = new Queue<int>();
        Queue<int> nums2q = new Queue<int>();
        foreach(int n in nums1){
            nums1q.Enqueue(n);
        }
        
        foreach(int n in nums2){
            nums2q.Enqueue(n);
        }
        
        while(nums1q.Count >  0 && nums2q.Count > 0) {
            if(nums1q.Peek() < nums2q.Peek()){
                nums1q.Dequeue() ;
            }else if (nums1q.Peek() > nums2q.Peek()){
                nums2q.Dequeue() ;
            }else{
                list.Add(nums1q.Dequeue());
                nums2q.Dequeue();
            }
        }
        
        // return 
        return list.ToArray();
        
    }
}