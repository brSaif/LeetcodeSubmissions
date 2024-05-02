public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        return triangle
               .Reverse()
               .Skip(1)
               .Aggregate(
                   triangle.Last(),
                   (acc, x) => acc
                               .Zip(acc.Skip(1), (a, b) => Math.Min(a, b))
                               .Zip(x, (a, b) => a + b)
                               .ToList())
               .First();
    }
}