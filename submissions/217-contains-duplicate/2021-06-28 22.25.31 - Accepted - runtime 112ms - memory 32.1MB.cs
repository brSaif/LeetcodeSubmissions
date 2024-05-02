public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        foreach(int n in nums){
            if(!set.Add(n)) return true; // yes
        }
        return false;
    }
}