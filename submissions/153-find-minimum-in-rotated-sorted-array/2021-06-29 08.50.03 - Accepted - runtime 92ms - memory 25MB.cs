public class Solution {
    public int FindMin(int[] nums) {
        int ans = nums[0];
        for(int i = 1; i < nums.Length; i++){
            if(ans > nums[i]) return nums[i];
        }
        return ans;
    }
}