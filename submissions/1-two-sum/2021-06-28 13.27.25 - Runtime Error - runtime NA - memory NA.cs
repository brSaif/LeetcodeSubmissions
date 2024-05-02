public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        IDictionary<int,int> occur = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            if(!occur.ContainsKey(nums[i])){ 
                occur[nums[i]] = i;
                continue;
            }
            occur.Add(nums[i],i);
        }
        
        for(int i = 0; i < nums.Length; i++){
            var diff = target - nums[i];
            if(occur.ContainsKey(diff) && i < occur[diff]) return new int[]{i,occur[diff]};
        }
        
        return new int[1];
    }
}