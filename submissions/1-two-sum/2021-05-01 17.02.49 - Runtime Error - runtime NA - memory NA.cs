public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        IDictionary<int,int> intDict = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            if(!intDict.ContainsKey(nums[i])) intDict.Add(nums[i],i);
        }
        
        for(int i = 0; i < intDict.Count; i++){
            int rest  = target - nums[i];
            if(intDict.ContainsKey(rest) 
               && intDict[rest] != i) return new int[]{i,intDict[rest]};
        }
        
        throw new Exception ("No solution found ");
    }
}