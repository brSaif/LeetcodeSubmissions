public class Solution {
   
        public int Dp(int[] nums, int index, Dictionary<int, int> memo)
    {
        if (index >= nums.Length) return 0;
        if (memo.ContainsKey(index)) return memo[index];
        var currMax = Math.Max(nums[index] + Dp(nums, index + 2, memo), 
                               Dp(nums, index + 1, memo));
        memo[index] = currMax;
        return currMax;
    }
    
    public int Rob(int[] nums) {
        return Dp(nums, 0, new Dictionary<int, int>());
    }
}