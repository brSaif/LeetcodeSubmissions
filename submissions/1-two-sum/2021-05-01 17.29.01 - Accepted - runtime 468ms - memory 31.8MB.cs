public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        IDictionary<int,int> numsD = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length ; i++){
            int rest = target - nums[i];
            
            if(numsD.ContainsKey(rest)){
                if(numsD[rest] != i){
                    return new int[]{i,numsD[rest]}; 
                }
            }else{
                numsD.Add(nums[i],i);
            }
            
        }
        
        throw new Exception("No solution found");
    }
}