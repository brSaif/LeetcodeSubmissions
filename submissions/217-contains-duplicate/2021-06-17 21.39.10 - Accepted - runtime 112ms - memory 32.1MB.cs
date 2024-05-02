public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> numsSet = new HashSet<int>();
        foreach(int n in nums){
            if(numsSet.Contains(n)) return true;
            numsSet.Add(n);
        }
        return false;
    }
}