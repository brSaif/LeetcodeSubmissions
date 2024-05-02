public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) =>
        intervals.OrderBy(i => i[0]).ThenByDescending(i => i[1])
		.Aggregate((Result: 0, Right: 0), (t, i) => i[1] > t.Right ? (t.Result + 1, i[1]) : t).Result;

}