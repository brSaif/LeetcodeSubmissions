public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        
        if (k > nums.Length)
            return -1;
        
        Array.Sort(nums);
        Array.Reverse(nums);
        return nums[k -1];
    }
}