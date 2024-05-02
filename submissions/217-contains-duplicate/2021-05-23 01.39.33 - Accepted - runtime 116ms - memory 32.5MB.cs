public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        IDictionary<int,int> dup = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length ; i++){
            if(dup.ContainsKey(nums[i])){
                return true;
            }else{
                dup.Add(nums[i],1);
            }
        }
        return false;
    }
}