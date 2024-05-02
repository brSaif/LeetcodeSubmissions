public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int count = 0;
        for(int index = 0; index < nums.Length; index++){
            if(nums[count] < nums[index]) nums[++count] = nums[index];
        }
        
        return count+1;
    }
}