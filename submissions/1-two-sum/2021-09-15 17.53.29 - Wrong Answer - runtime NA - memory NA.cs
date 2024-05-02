public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        // The Google way of doing it
        var   seen = new Dictionary<int,int>();
        
        for(int i = 0; i < nums.Length; i++){
            int comp = Math.Abs(target - nums[i]);
            if(seen.ContainsKey(comp) && seen[comp] != i) return new int[]{i,seen[comp]};
            else if(seen.ContainsKey(nums[i])) seen[nums[i]] = i;
            else seen.Add(nums[i],i) ;
        }
        
         return new int[]{};
    }
}