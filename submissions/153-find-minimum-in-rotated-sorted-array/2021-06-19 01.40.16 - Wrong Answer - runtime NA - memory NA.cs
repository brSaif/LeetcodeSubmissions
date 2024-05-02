public class Solution {
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length -1;
        int min = Int32.MaxValue;
        while(left < right){
            int mid = left + (right - left)/2;
            if(nums[left] < nums[mid] && nums[left] < nums[right]) {
                right = mid - 1;
                min = Math.Min(nums[left], nums[mid]);
            }else{
                left = mid + 1;
                min = Math.Min(nums[right], nums[mid]);
            }
        }
        return min;
    }
}