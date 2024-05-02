public class Solution {
    public bool Search(int[] nums, int target) {
        if (nums is null || nums.Length == 0)
            return false;
        
        int l = 0, h = nums.Length -1;
        while (l <= h){
            while(l < h && nums[l] == nums[l+1])
                l++;
            while (h > l && nums[h] == nums[h - 1])
                h--;
            
            int mid = l + (h - l) /2;
            
            if(nums[mid] == target) 
                return true;
            
            if (nums[mid] >= nums[l]) {
                if (target >= nums[l] && target < nums[mid])
                    h = mid - 1;
                else 
                    l = mid + 1;
            }else {
                if (target <= nums[h] && target > nums[mid])
                    l = mid + 1;
                else
                    h = mid - 1;
            }
        }
        
        return false;
    }
}