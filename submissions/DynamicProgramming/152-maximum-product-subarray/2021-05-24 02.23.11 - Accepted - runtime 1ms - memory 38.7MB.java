class Solution {
    public int maxProduct(int[] nums) {
        int max_overall=nums[0],max_e_h=nums[0],min_e_h=nums[0],temp,i;
    for(i=1;i<nums.length;i++)
    {
        temp=max_e_h;
        max_e_h=Math.max(nums[i],Math.max(nums[i]*max_e_h,nums[i]*min_e_h));
        min_e_h=Math.min(nums[i],Math.min(nums[i]*temp,nums[i]*min_e_h));
        
        max_overall=Math.max(max_overall,max_e_h);
    }
    
    return max_overall;
    }
    
}