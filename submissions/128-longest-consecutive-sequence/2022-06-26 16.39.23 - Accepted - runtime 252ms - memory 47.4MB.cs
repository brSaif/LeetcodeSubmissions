public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = nums.ToHashSet();
        return set.Where(n => !set.Contains(n - 1))
            .DefaultIfEmpty(0)
            .Max(n => Enumerable.Range(n, 100000).TakeWhile(set.Contains).Count());
    }
}