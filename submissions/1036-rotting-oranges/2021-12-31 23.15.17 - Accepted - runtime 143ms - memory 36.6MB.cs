public class Solution {
     private List<(int, int)> Dirs = new List<(int, int)>() { (0, -1), (0, 1), (-1, 0), (1, 0) } ; 
        
    public int OrangesRotting(int[][] grid) 
    {
        var q = new Queue<(int, int)>(FindRottenOranges(grid));
        int minMinutes = 0;
        
        while (q.Count > 0)
        {
            minMinutes += 1;
            int size = q.Count;
            for (int times = 0; times < size; times++)
            {
                var (i, j) = q.Dequeue();
                foreach (var (di, dj) in Dirs)
                {
                    int ni = i + di, nj = j + dj;
                    if (0 <= ni && ni < grid.Length && 0 <= nj && nj < grid[0].Length && grid[ni][nj] == 1)
                    {
                        grid[ni][nj] = 2;
                        q.Enqueue((ni, nj));
                    }
                }
            }
        }
        
        return AllOrangesRotten(grid) ? Math.Max(0, minMinutes - 1) : -1;
    }
    
    private IList<(int, int)> FindRottenOranges(int[][] grid)
    {
        var res = new List<(int, int)>();
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 2)
                {
                    res.Add((i, j));
                }
            }
        }
        return res;
    }
    
    private bool AllOrangesRotten(int[][] grid)
    {
        foreach (var row in grid)
        {
            foreach (var cell in row)
            {
               if (cell == 1)
               {
                   return false;
               }
            }
        }
        return true;
    }
}