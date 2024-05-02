public class Solution {
    public int[] SortedSquares(int[] nums) {
        
        int len = nums.Length -1;
        int l = 0, h = len;
        var res = new int[len + 1];
        for(int i = len; i >= 0 ; i--){
            if(Math.Abs(nums[l]) < Math.Abs(nums[h])){
                res[i] = nums[h] * nums[h--];
            }else{
                res[i] = nums[l] * nums[l++];
            }
        }
        
        return res;
        
    }
}