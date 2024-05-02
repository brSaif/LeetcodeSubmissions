public class Solution {
    public int MaxSubArray(int[] nums) {
        int currSum = nums[0];
        int res = 0;
        if(nums.Length == 1) return nums[0];
        for(int i = 1; i < nums.Length; i++){
            if(currSum < 0) currSum = 0;
            currSum += nums[i];
            res = Math.Max(res, currSum);
        }
        return res;
    }
}