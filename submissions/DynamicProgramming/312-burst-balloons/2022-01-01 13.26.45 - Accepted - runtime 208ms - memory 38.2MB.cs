public class Solution {
    public int MaxCoins(int[] nums) {
        int len =  nums.Length;
        if (len == 0) return 0;
        
        int[,] dp = new int[len,len];
        
        for (int l = 1; l <= len; l ++)
        {
            for (int start = 0; start <= len - l; start ++){
                
                int last = start + l - 1;
                for (int k = start; k <= last; k++){
                    int leftSum = k - 1 < start ? 0 : dp[start, k - 1];
                    int rightSum = k + 1 > last ? 0 : dp[k + 1,last];
                    
                    int leftNum = start - 1 < 0 ? 1 : nums[start -1];
                    int rightNum = last + 1 >= len ? 1 : nums[last + 1];
                    
                    dp[start, last] = Math.Max(dp[start, last], 
                                               leftSum + 
                                               (leftNum * nums[k] * rightNum) +
                                               rightSum);
                }
            }
        }
        return dp[0, len -1];
    }
}