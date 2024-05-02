public class Solution {
    public void NextPermutation(int[] nums) {
        int len  = nums.Length -1;
        int i = len;
        while (i > 0){
            if (nums[i] > nums[i - 1]  ){
                Swap(nums, i, i - 1);
                Reverse(nums, i, len - i + 1);
                return;
            }
            i--;
        }
        
        Reverse(nums, 0, len + 1);
    }
    
    private void Swap(int[] arr, int v1, int v2){
        int tmp = arr[v1];
        arr[v1] = arr[v2];
        arr[v2] = tmp;
    }
    
    private void Reverse(int[] arr, int start, int count){
        Array.Reverse(arr, start, count);
    }
}