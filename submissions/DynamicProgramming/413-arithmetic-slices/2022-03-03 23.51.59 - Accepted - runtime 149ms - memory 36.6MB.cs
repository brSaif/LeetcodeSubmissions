public class Solution {
    public int NumberOfArithmeticSlices(int[] nums) {
        int len = nums.Length;
        int res = 0;
        var dp = new int[len];
        
        for (int i = 2; i < len; i++){
            if (nums[i - 2] - nums[i - 1] == nums[i - 1] - nums[i]) 
                dp[i] = dp[i - 1] + 1;
            res += dp[i];
        }
        
        return res;
    }
}