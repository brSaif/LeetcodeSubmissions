public class Solution {
    public int MaxProduct(int[] nums) {
        //int maxProduct = nums[0]; 
        //int minProduct = 1;
        //int currProduct = 1 ;
        //foreach(int n in nums){
        //    if(n != 0 && currProduct == 0) currProduct = 1;
        //    minProduct *= n;
        //    currProduct *= n;
        //    minProduct = Math.Min(currProduct,n);
        //    maxProduct = Math.Max(Math.Max(minProduct,maxProduct),Math.Max(currProduct,n));
        // }
        // return maxProduct;
        
        int max_overall=nums[0],max_e_h=nums[0],min_e_h=nums[0],temp,i;
        for(i=1;i<nums.Length;i++)
        {
            temp=max_e_h;
            max_e_h=Math.Max(nums[i],Math.Max(nums[i]*max_e_h,nums[i]*min_e_h));
            min_e_h=Math.Min(nums[i],Math.Min(nums[i]*temp,nums[i]*min_e_h));

            max_overall=Math.Max(max_overall,max_e_h);
        }

        return max_overall;
    
    }
}