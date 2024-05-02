public class Solution {
    public int FindMin(int[] nums) {
        int pre = nums[0];
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] < pre)
                return nums[i];
        }
        return nums[0];
    }
}