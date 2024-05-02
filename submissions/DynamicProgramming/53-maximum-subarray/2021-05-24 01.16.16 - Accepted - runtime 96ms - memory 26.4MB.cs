public class Solution {
    public int MaxSubArray(int[] nums) {
        int currSum = 0;
        int maxSum= nums[0];
        foreach(int n in nums){
            if(currSum < 0) currSum = 0;
            currSum += n;
            maxSum = Math.Max(maxSum,currSum); 
        }
        return maxSum;
    }
}