public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0 || nums.Length == 1) return nums.Length;
        int count = 0;
        for(int index = 0; index < nums.Length; index++){
            if(nums[count] < nums[index]) nums[++count] = nums[index];
        }
        
        return count+1;
    }
}