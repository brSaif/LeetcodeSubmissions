public class Solution {
    public int FindMin(int[] nums) {
        int res = int.MaxValue;
        int l = 0, r = nums.Length -1;
        
        while(l <= r){
            int mid = l + (r -l)/2;
            if(nums[l] < nums[r]) {
                r--;
            }else{
                l++;
            }
            res = Math.Min(res, nums[mid]);
        }
        
        return res;
    }
}