public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        return
            // Generate list of diff results (value - index)
            nums.Select((s, i) => s - i)
            // Zip the diff result list to value list using key value pairs
            .Zip(nums, (k, v) => new KeyValuePair<int, int>(k, v))
            // Group by diff result (the group id key)
            .GroupBy(p => p.Key, e => e.Value)
            // Use select to convert grouped ranges to required format
            .Select((r) =>
               {
                  int a = r.First();
                  int b = r.Last();
                  if (a == b)
                  {
                     return a.ToString();
                  }
                  else
                  {
                     return a.ToString() + "->" + b.ToString();
                  }
               })
            // Convert to list for return.
            .ToList();
    }
}