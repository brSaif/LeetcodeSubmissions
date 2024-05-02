public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int numsLen = nums.Length;
        int prod = 1;
        int zeroesNbr = 0;
        int[] answer = new int[numsLen];
        for(int i = 0; i < numsLen; i++){
            if(nums[i] != 0) {
                prod *= nums[i];
            }else{
                zeroesNbr += 1;
            }
        }
        
       for(int i = 0; i < numsLen; i++){  
           if(zeroesNbr >= 2) {
                answer[i] = 0;
           }else if(zeroesNbr == 1)
           {
               if(nums[i] == 0){
                    answer[i] = prod;
               }else{
                    answer[i] = 0;
               }
           }else{
                    answer[i] = prod / nums[i];
           }
       }
        return answer;
   }
        
   
}