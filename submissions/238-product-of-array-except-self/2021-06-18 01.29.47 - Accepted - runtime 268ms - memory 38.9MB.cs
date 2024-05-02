public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int zCount = 0;   
        int prod = 1;
        
        for(int i = 0; i < nums.Length ; i++){
            if(nums[i] != 0) {
                prod *= nums[i];
                continue;
            }
            zCount ++;
        }
        
        for(int i = 0; i < nums.Length; i++){
            if(zCount > 1) {
                nums[i] = 0;
                continue;
            }
            if(zCount == 1){
                if(nums[i] != 0){
                    nums[i] = 0;
                }else{
                    nums[i] = prod;
                }
            }
            if(zCount == 0){
                nums[i] = prod / nums[i];
            }
        }
        
        return nums;
    }
}