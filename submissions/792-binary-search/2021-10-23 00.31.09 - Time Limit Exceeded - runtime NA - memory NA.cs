public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0, h = nums.Length - 1;
        
        while(l < h){
            int mid = (l + h)/2;
            if(target == nums[mid]) return mid;
            
            if(target > nums[mid]) 
            {l = mid;}
            else { h = mid;};
        }
        
        return -1;
    }
}