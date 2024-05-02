public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        
        int maxConsecutive = 1;
        for(int i = 0 ; i < nums.Length ;  i++){
            if(nums[i] == maxConsecutive){
                while(nums[i] == nums[i+1]){
                    maxConsecutive++;
                }
            }else{
                maxConsecutive = 1;
            }
        }
        
        return maxConsecutive;
    }
}