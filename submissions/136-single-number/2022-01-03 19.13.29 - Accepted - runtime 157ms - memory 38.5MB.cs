public class Solution {
    public int SingleNumber(int[] nums) {
        
        int c = nums[0];
        for (int i = 1; i < nums.Length; i++){
            c ^= nums[i];
        }
        
        return c;
    }
}