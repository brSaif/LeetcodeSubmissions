public class Solution {
    public int GetMaximumGold(int[][] grid) {
         int ROWS = grid.Length;
        int COLS = grid[0].Length;
        int res=0;

        int DFS(int r,int c, HashSet<(int,int)> visited){
            if(r<0 || r==ROWS || c<0 || c== COLS || grid[r][c]==0|| visited.Contains((r,c))){
                return 0;
            }
            visited.Add((r,c));
            int amt = grid[r][c];

            amt = Math.Max(amt, grid[r][c] + DFS(r+1,c,visited)); 
            amt = Math.Max(amt, grid[r][c] + DFS(r-1,c,visited)); 
            amt = Math.Max(amt, grid[r][c] + DFS(r,c+1,visited)); 
            amt = Math.Max(amt, grid[r][c] + DFS(r,c-1,visited)); 
        
            visited.Remove((r,c));
            return amt;
        }

        for(int r=0;r<ROWS;r++){
            for(int c=0;c<COLS;c++){
                if(grid[r][c]!=0){
                    var amt = DFS(r,c,new HashSet<(int,int)>());
                    res = Math.Max(res,amt);
                }
            }
        }

        return res;
    }
}