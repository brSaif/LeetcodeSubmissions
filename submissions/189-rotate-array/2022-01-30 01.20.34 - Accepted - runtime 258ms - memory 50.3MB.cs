public class Solution {
    public void Rotate(int[] nums, int k) {
        int len = nums.Length;
        k%= len;
        Array.Reverse(nums);
        Array.Reverse(nums, 0, k);
        Array.Reverse(nums,k, len - k);
    }
}