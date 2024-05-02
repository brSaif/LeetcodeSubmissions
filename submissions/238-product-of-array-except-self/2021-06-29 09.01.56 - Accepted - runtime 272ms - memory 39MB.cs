public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
         int zcount = 0;
        int maxProd = 1;
        foreach(int n in nums){
            if(n != 0){
                maxProd *= n;
            }else{
                zcount +=1;
            }
        }
        
        if(zcount >= 2) {Array.Fill(nums,0);
                        return nums;}
        
        for(int i = 0; i < nums.Length; i++){
            if(zcount == 1){
                if(nums[i] == 0) nums[i] = maxProd;
                else{nums[i] = 0;}
                continue;
            }
            
            nums[i] = maxProd/nums[i];
        }
        
        return nums;
    }
}