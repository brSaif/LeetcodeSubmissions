public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var res = new int[2];
        int l = 0, h = nums.Length -1; 
        while(l < h){
            if(nums[l] + nums[h] == target){
                res[0] = l+1;
                res[1] = h+1;
                break;
            }
            
            if(nums[l] + nums[h] > target) h--;
            else l++;
        }
        
        return res;
    }
}