public class Solution {
    public void Rotate(int[] nums, int k) {
        if(nums.Length <= 1) return;
        k %= nums.Length;
        Array.Reverse(nums);
        Array.Reverse(nums,0,k);
        Array.Reverse(nums,k,nums.Length - k);
    }
}