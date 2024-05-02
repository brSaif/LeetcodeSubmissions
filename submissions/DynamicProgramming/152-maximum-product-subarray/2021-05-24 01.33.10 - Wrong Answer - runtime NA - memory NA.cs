public class Solution {
    public int MaxProduct(int[] nums) {
        int maxProduct = nums[0];        
        int currProduct = 1 ;
        foreach(int n in nums){
            if(n != 0 && currProduct == 0) currProduct = 1;
            currProduct *= n;
            maxProduct = Math.Max(maxProduct,currProduct);
        }
        return maxProduct;
    }
}