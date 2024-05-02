public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        
        int len = nums.Length;
        
        if (k > len)
            return -1;
        
        Array.Sort(nums);
        return nums[len - k];
    }
}