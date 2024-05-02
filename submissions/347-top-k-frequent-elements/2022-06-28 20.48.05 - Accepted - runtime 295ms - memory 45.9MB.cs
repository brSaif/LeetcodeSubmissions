public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
        => nums.GroupBy(x => x)
            .ToDictionary(g => g.Key, g => g.Count())
            .OrderByDescending(x => x.Value)
            .Select(x => x.Key)
            .Take(k)
            .ToArray();
}