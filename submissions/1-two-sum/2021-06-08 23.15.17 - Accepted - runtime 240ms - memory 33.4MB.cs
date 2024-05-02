public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int rest = 0;
      // Populate Dictionary with distinct array values  
        IDictionary<int,int> distinctNums = new Dictionary<int,int>();
        for(int i = 0 ; i < nums.Length; i++){
            // make of the value the key and its index in [nums] the value
            if(distinctNums.ContainsKey(nums[i])){
                distinctNums[nums[i]] = i; 
            }else{
                distinctNums.Add(nums[i],i);
            }
        }
        
        for(int i = 0 ; i < nums.Length ; i++){
            rest = target - nums[i];
            if(distinctNums.ContainsKey(rest)
              && distinctNums[rest] > i){
                return new int[]{i,distinctNums[rest]};
            }
        }
        
        throw new Exception("Solution not found");
    }
}