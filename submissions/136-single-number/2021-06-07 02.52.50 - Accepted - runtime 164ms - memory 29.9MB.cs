public class Solution {
    public int SingleNumber(int[] nums) {
        int a = 0;
        foreach(var c in nums){
            a ^= c;
        }
        return a;
        
        
    }
}