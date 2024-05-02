public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        IDictionary<int,int> occur = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            if(!occur.ContainsKey(nums[i])) occur.Add(nums[i],i);
            else occur[nums[i]] = i;
        }
        
        for(int i = 0; i < nums.Length; i++){
            var diff = target - nums[i];
            if(occur.ContainsKey(diff) && occur[i] != i) return new int[]{occur[diff],i};
        }
        
        throw new Exception();
    }
}