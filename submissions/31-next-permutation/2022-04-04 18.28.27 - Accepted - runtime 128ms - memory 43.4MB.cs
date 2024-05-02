public class Solution {
    public void NextPermutation(int[] nums) {
        int len  = nums.Length;
        int i = len - 2;
        
        while (i >= 0 && nums[i + 1] <= nums[i])
            i--;
        if (i >= 0){
            int j = len - 1;
            while (nums[j] <= nums[i])
                j--;
            Swap(nums, i, j);
        }
        Reverse(nums, i + 1, len - i -1);
    }
    
    private void Swap(int[] nums, int v1, int v2){
        int tmp = nums[v1];
        nums[v1] = nums[v2];
        nums[v2] = tmp;
    }
    
    private void Reverse(int[] nums, int start, int end)
        => Array.Reverse(nums, start, end);
}