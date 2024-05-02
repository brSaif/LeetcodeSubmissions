public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> numsSet = new HashSet<int>();
        for(int i =0; i < nums.Length; i++){
            if(!numsSet.Contains(nums[i])){
                numsSet.Add(nums[i]);
                continue;
            }
            return true;
        }
        return false;
    }
}