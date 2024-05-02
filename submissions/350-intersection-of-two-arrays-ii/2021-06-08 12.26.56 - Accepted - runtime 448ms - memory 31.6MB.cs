public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        
        Queue<int> stk1 = new Queue<int>();
        Queue<int> stk2 = new Queue<int>();
        Array.Sort(nums1);
        Array.Sort(nums2);
        
        foreach(var n in nums1){
            stk1.Enqueue(n);
        }
        
        foreach(var n in nums2){
            stk2.Enqueue(n);
        }
                
        if(stk1.Count == 0 || stk2.Count == 0) return new int[1];
        
        IList<int> res = new List<int>();
        
        while(stk1.Count > 0 && 
              stk2.Count > 0){
            if(stk1.Peek() < stk2.Peek() ){
                stk1.Dequeue();
            }else if(stk1.Peek() > stk2.Peek()){
                stk2.Dequeue();
            }else{
                res.Add(stk2.Dequeue());
                stk1.Dequeue();
            }
        }
        
        return res.ToArray();
    }
}