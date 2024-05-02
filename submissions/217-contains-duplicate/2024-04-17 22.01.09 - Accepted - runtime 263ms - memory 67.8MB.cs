public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> set = new ();
        foreach(var n in nums)
            if(!set.Add(n))
                return true;

        return false;
    }
}