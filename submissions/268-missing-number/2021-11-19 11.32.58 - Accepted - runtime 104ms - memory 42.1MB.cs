public class Solution {
    public int MissingNumber(int[] nums) {
        
        int len = nums.Length;
        int res = 0, j = 0;
        for(int i = 1; i <= len; i++){
            res ^= i ^ nums[j++] ;
        }
        return res;
    }
}