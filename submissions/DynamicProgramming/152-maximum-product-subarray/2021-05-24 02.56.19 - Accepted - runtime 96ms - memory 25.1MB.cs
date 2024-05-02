public class Solution {
    public int MaxProduct(int[] nums) {
        int maxProduct = nums[0]; 
        int currMin = 1;
        int currMax = 1 ;
        foreach(int n in nums){
            if(n == 0) {
                currMax = 1;
                currMin = 1;
            }
            
            int temp = currMin * n;
            currMin = Math.Min(Math.Min(temp,currMax*n),n);
            currMax = Math.Max(Math.Max(temp,currMax*n),n);
            maxProduct = Math.Max(Math.Max(currMin,maxProduct),currMax);
        }
        return maxProduct;
    }
}