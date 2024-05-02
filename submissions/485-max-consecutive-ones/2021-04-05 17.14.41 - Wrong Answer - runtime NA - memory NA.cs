public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        
        int consecutiveMax = 0;
        int numsLen = nums.Length;

        
        for(int counter = 0 ; counter < numsLen -2 ; counter++){
            
            if(counter > numsLen -2) {return consecutiveMax;}
            else {
                    if(nums[counter] == 1)
                    {
                        
                        int loConsecutiveMax = 1;
                        while(nums[counter] == nums[counter + 1])
                        {
                              loConsecutiveMax++;
                            counter++;
                        }
                        
                        if(consecutiveMax < loConsecutiveMax) consecutiveMax = loConsecutiveMax;
                    }
                
            }
                 
            
        }
        return consecutiveMax;
        
        
    }
}