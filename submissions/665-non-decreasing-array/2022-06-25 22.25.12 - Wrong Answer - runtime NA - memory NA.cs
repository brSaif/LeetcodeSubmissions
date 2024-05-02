public class Solution {
    public bool CheckPossibility(int[] nums) {
        
        if (nums.Length <= 2) 
            return true;
        
        var count = 0;
        int i = 0;
        while (i < nums.Length -1){
            
            if (nums[i] > nums[i + 1])
                count++;
            
            if (count > 1)
                return false;
            
            i++;
        }
        
        return true;
    }
}
