public class Solution {
    public int Rob(int[] nums) {
        int L = nums.Length;
        if(L == 1) return nums[0];
        if(L == 2) return Math.Max(nums[0], nums[1]);
        nums[1] = Math.Max(nums[0], nums[1]);
        for(int i = 2; i < L; i++){
            nums[i] = Math.Max(nums[i - 1], nums[i - 2] + nums[i]);
        }
        
        return nums[L - 1];
    }
}