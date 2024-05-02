public class Solution {
    public int MaxSubArray(int[] nums) {
        int res= 0;
        int currSum = 0;
        for(int i = 0; i < nums.Length ; i++){
           currSum += nums[i];
           if(currSum < 0) currSum = 0;
            res = Math.Max(currSum,res);
        }
        return res;
    }
}