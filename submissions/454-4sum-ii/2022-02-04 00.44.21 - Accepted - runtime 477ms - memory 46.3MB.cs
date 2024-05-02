public class Solution {
    public int FourSumCount(int[] A, int[] B, int[] C, int[] D) =>
    A.SelectMany(a => B.Select(b => a + b)).GroupBy(s => s).Join(
    C.SelectMany(c => D.Select(d => c + d)).GroupBy(s => s),
    g => g.Key, g => -g.Key,
    (x, y) => x.Count() * y.Count()).Sum();
}