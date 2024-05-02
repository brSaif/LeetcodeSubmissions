public class Solution {
    public int[][] ReconstructQueue(int[][] people) => people
    .OrderByDescending(p => p[0])
    .ThenBy(p => p[1])
    .Aggregate(Array.Empty<int[]>(), (arr, p) => arr
        .Take(p[1])
        .Append(p)
        .Concat(arr.Skip(p[1]))
        .ToArray()
    );
}