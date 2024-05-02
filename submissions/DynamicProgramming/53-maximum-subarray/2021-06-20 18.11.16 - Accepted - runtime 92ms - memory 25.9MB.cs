public class Solution {
    public int MaxSubArray(int[] nums) {
        int res= nums[0];
        int currSum = 0;
        if(nums.Length == 1) return nums[0];
        for(int i = 0; i < nums.Length ; i++){
           if(currSum < 0) currSum = 0;
            currSum += nums[i];
            res = Math.Max(currSum,res);
        }
        return res;
    }
}