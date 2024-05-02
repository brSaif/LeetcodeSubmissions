public class Solution {
    public int MaxProduct(int[] nums) {
        int currMin = 1,currMax = 1,res = nums[0];
        
        for(int i = 0; i < nums.Length ; i++) {
            int temp = currMin * nums[i];
            currMin = Math.Min(Math.Min(temp,currMax*nums[i]),nums[i]);
            currMax = Math.Max(Math.Max(temp,currMax*nums[i]),nums[i]);
            res = Math.Max(Math.Max(res,currMax),nums[i]);
        }
        
        return res;
    }
}