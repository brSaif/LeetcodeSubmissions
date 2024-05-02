public class Solution {
    public int FindPairs(int[] nums, int k) {
        if (k == 0)
        {
            return nums.GroupBy(x => x).Count(g => g.Count() > 1);
        }
        var set = new HashSet<int>(nums);
        return set.Count(x => set.Contains(x + k));
    }
}