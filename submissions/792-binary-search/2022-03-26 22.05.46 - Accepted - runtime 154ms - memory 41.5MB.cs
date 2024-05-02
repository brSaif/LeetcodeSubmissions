public class Solution {
    public int Search(int[] nums, int target) {
        int h = nums.Length -1, l = 0;
        while (l <= h){
            int mid  = (h + l)/2;
            if (nums[mid] == target) return mid;
            if (nums[mid] < target)  
                l = mid + 1 ;
            else 
                h = mid - 1;
        }
        
        return -1;
    }
}