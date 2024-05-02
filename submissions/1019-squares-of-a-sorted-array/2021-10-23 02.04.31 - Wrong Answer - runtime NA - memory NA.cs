public class Solution {
    public int[] SortedSquares(int[] nums) {
        
        int hight = nums.Length -1, low = 0;
        while(hight >= low){
          if(nums[low] * nums[low] > nums[hight] * nums[hight]){
              int tmp = nums[hight];
              nums[hight] = nums[low];
              nums[low] = tmp;
              hight --;
              continue;
          }
            
         hight --;
              
          
        }
        
        for(int i = 0; i < nums.Length; i++ ){
            nums[i] *= nums[i];
        }
        
        return nums;
    }
}