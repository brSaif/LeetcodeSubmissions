public class Solution {
    public int MajorityElement(int[] nums) {
     
        int count = 0;
        int? candidate = null;
        
        foreach (var num in nums){
            if (count == 0)
                candidate  = num;
            count += (candidate == num) ? 1 : -1;
        }
        
        return candidate ?? -1;
    }
}