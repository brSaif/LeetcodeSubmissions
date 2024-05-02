public class Solution {
    public int FindMinArrowShots(int[][] points) {
        
        return points.OrderBy(p => p[0])
		.ThenBy(p => p[1])
		.Aggregate((Arrows: 0, LastArrow: long.MinValue),
			(t, p) => t.LastArrow >= p[0]
				? (t.Arrows, Math.Min(t.LastArrow, p[1]))
				: (t.Arrows + 1, p[1]))
		.Arrows;
    }
}