public class Solution {
    public int MaxCoins(int[] nums) {
        int len = nums.Length;
        var cache = new int[len,len];
        return MaxCoins(nums, 0, len - 1, cache);
    }
    
    private int MaxCoins(int[] nums, int i, int j, int[,] cache){
        if (i > j) return 0;
        if (cache[i, j] != 0) return cache[i, j];
        int maxCoins = 0;
        for (int k = i; k <= j; k++){
            int left = i - 1 < 0 ? 1 : nums[i - 1];
            int right = j + 1 >= nums.Length ? 1 : nums[j + 1];
            
            maxCoins = Math.Max(maxCoins,
                               left * nums[k] * right
                               + MaxCoins(nums, i, k - 1, cache)
                               + MaxCoins(nums, k + 1, j, cache)) ;
        }
        
        cache[i, j] = maxCoins;
        return maxCoins;
        
    }
}