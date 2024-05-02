public class Solution {
    public int SingleNumber(int[] nums) {
        int a = 0;
        foreach(var c in nums){
            // a ^ 0 = a and a ^ a = 0
            a ^= c; 
        }
        return a;
    }
}