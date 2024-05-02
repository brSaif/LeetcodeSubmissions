public class Solution {
    public double ChampagneTower(int poured, int query_row, int query_glass) 
        => Math.Min(1.0, Solve(poured, 
                               query_row, 
                               query_glass, 
                               new Dictionary<(int, int), double>()));
    
    private double Solve(int p, int r, int c, Dictionary<(int, int), double> dp) {
        if (r == 0 && c == 0) return p;
        
        if (c < 0 || r < c) return 0;
        
        if (dp.TryGetValue((r, c), out var res)) return res;
        
        var left  = Math.Max(0.0, (Solve(p, r - 1, c, dp) - 1) / 2);
        var right = Math.Max(0.0, (Solve(p, r - 1, c - 1, dp) -1) / 2);
        
        dp[(r,c)] = left + right;
        return dp[(r,c)];
    }
    
   
    
}