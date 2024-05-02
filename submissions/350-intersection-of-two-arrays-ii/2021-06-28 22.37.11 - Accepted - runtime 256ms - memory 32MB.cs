public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        // check base cases
        if(nums1.Length == 0 || nums2.Length == 0) return new int[1];
        
        // sort both arrays
        Array.Sort(nums1);
        Array.Sort(nums2);
        
        //list to hold result
        var list = new List<int>();
        
        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();
        
        foreach(var n in nums1){
            q1.Enqueue(n);
        }
        
        foreach(var n in nums2){
            q2.Enqueue(n);
        }
        
        while(q1.Count > 0 && q2.Count > 0){
            if(q1.Peek() < q2.Peek()){
                q1.Dequeue();
            }else if(q1.Peek() > q2.Peek()){
                q2.Dequeue();
            }else{
                list.Add(q1.Dequeue());
                q2.Dequeue();
            }
        }
        return list.ToArray();
    }
}