public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
        => nums
            .GroupBy(x => x)
            .OrderByDescending(x => x.Count())
            .Select(x => x.Key)
            .Take(k)
            .ToArray();

}