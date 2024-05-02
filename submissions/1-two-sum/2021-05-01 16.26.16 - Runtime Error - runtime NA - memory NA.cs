public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length-2; i++){
            for(int j = i+1; j < nums.Length-1; i++){
                if((nums[i] + nums[j]) == target) return new int[]{i,j};
            }
        }
        
        throw new Exception ("No solution found ");
    }
}