public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> numsSet = new HashSet<int>();
        for(int i =0; i < nums.Length; i++){
            if(!numsSet.Contains(i)){
                numsSet.Add(i);
                continue;
            }
            return false;
        }
        return true;
    }
}