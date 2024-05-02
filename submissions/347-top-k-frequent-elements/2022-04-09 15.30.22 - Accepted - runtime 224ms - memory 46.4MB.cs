public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
        => nums.GroupBy(x => x)
            .ToDictionary(g => g.Key, g => g.Count())
            .OrderByDescending(p => p.Value)
            .Take(k)
            .Select(s => s.Key)
            .ToArray();
}