public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var seen = new HashSet<int>();
        foreach(var n in nums){
            if(!seen.Add(n)) return true;
        }
        return false;
    }
}