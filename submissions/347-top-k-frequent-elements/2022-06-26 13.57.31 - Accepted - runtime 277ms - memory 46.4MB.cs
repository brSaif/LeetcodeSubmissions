public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
        => nums.GroupBy(n => n)
            .ToDictionary(g => g.Key, g => g.Count())
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
}