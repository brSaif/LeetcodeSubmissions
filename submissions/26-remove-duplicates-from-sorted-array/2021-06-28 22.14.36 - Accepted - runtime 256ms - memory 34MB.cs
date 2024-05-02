public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length <= 1) return nums.Length;
        int count = 0;
        for(int i =1; i < nums.Length; i++){
            if(nums[count] < nums[i]) nums[++count] = nums[i];
        }
        return count +1;
    }
}