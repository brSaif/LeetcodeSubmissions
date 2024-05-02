public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        IDictionary<int,int> numsDict = new Dictionary<int,int>();
        // Populate the dictionary with unique nbrs with their index
        for(int i = 0; i < nums.Length; i++){
            if(!numsDict.ContainsKey(nums[i])) numsDict.Add(nums[i],i);
            numsDict[nums[i]] = i; // Update the index of the element if it exists elsewhere int the arr
        }
        
        for(int i = 0; i < nums.Length; i++){
            int rest = target - nums[i];
            if(numsDict.ContainsKey(rest) && i != numsDict[rest]) return new int[]{i,numsDict[rest]};
        }
        
        return new int[]{};
    }
}