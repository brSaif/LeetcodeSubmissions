public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var dictionary =  new Dictionary<int,int>();
        
        for(int i = 0; i < nums.Length; i++){
            var comp = target - nums[i];
            if(dictionary.ContainsKey(comp) && dictionary[comp] != i){
                return new int[]{i,dictionary[comp]};
            }
            else if(dictionary.ContainsKey(comp)) dictionary[comp] = i;
            else dictionary.Add(nums[i],i);
        }
        
        return new int[]{};
    }
}