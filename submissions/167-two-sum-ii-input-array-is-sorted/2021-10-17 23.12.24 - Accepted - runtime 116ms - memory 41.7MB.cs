public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int[] res = new int[2];
       
        int l = 0, r = nums.Length-1;
        while(l < r) {
            if(nums[l]+nums[r] == target) {
                res[0] = l+1; res[1] = r+1;
                break;
            }
            if(nums[l]+nums[r] < target) {
                l++;
            } 
            else {
                r--;
            }
        }
        return res;
    }
}
// 2 3 7 11 15 --> 9
