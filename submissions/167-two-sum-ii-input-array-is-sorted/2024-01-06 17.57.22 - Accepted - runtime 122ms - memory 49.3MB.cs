public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int h = nums.Length - 1;
        int l = 0;
        while(h > l){
            if (nums[h] + nums[l] == target)
                return new int[]{++l, ++h};
            
            if (nums[h] + nums[l] > target)
                h--;
            else 
                l++;

        }

        return new int[]{};
    }
}