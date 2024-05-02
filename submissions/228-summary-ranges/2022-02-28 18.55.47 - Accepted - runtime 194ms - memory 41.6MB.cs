public class Solution {
    public IList<string> SummaryRanges(int[] nums) 
        => nums.Select((s, i) => s - i)
            .Zip(nums, (k, v) => new KeyValuePair<int, int>(k, v))
            .GroupBy(g => g.Key, g => g.Value)
            .Select(s => {
                int a = s.First();
                int b = s.Last();
                
                return a == b ? a.ToString() : a+"->"+b;
            }).ToList();
}