public class Solution {
    public int FindJudge(int n, int[][] trust)
        => Enumerable.Range(1, n)
            .Except(trust.Select(t => t[0]))
            .Take(1)
            .Where(x => trust.Count(tp => tp[1] == x) == n - 1)
            .Append(-1).First();
}