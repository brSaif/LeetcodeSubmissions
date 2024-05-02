public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) =>
        mat.Select((r, index) => new {index, count = r.Where(x => x == 1).Count()})
            .OrderBy(x => x.count)
            .ThenBy(x => x.index)
            .Select(x => x.index)
            .Take(k)
            .ToArray();
}