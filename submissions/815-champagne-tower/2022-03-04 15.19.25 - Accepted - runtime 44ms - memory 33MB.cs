public class Solution {
    public double ChampagneTower(int poured, int query_row, int query_glass) 
        => Math.Min(1.0, Solve(poured, 
                               query_row, 
                               query_glass, 
                               new Dictionary<(int, int), double>()));
    
    private double Solve(int p, int r, int g, Dictionary<(int, int), double> dp) {
        if (r == 0 && g == 0) return p;
        
        if (g < 0 || g > r) return 0;
        
        if (dp.TryGetValue((r, g), out var res)) return res;
        
        var left = Math.Max((Solve(p, r-1, g-1, dp) - 1) / 2, 0.0);
        var right = Math.Max((Solve(p, r-1, g, dp) - 1) / 2, 0.0);
        
        dp[(r,g)] = left + right;
        return dp[(r,g)];
    }
    
    
}