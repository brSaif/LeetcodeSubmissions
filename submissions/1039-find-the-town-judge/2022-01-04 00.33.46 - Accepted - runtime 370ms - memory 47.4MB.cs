public class Solution {
    public int FindJudge(int n, int[][] trust) => Enumerable
            .Range(1, n).Except(trust.Select(tp => tp[0])) // ones who trust nobody
            .Take(1) // there can be only one
            .Where(x => trust.Count(tp => tp[1] == x) == n - 1) // do everyone trust him?
            .Append(-1).First();
}