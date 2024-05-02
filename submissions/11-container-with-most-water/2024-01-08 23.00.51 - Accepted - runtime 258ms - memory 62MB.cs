public class Solution {
    public int MaxArea(int[] nums) {
     var max = 0;
     int left = 0;
     int right = nums.Length - 1;
     while (left < right){
         var currArea = (right - left) * Math.Min(nums[left], nums[right]);
         max = max > currArea ? max : currArea;
         if(nums[left] < nums[right])
            left++;
        else
            right--;
     }
     return max;
    }
}