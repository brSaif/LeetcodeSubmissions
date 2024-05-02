public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        bool[,] seen = new bool[grid.Length, grid[0].Length];
        int[] dr = new int[]{1, -1, 0, 0};
        int[] dc = new int[]{0, 0, 1, -1};
        
        int ans = 0;
        for (int r0 = 0; r0 < grid.Length; r0 ++){
            for (int c0 = 0; c0 < grid[0].Length; c0 ++){
                if (grid[r0][c0] == 1 && !seen[r0, c0]){
                    int shape = 0;
                    Queue<int[]> stk = new ();
                    stk.Enqueue(new int[]{r0, c0});
                    seen[r0, c0] = true;
                    while (stk.Any()){
                        int[] node = stk.Dequeue();
                        int r = node[0], c = node[1];
                        shape++;
                        for (int k = 0; k < 4; k++){
                            int nr = r + dr[k];
                            int nc = c + dc[k];
                            if (0 <= nr && nr < grid.Length
                               && 0 <= nc && nc < grid[0].Length
                               && grid[nr][nc] == 1 && !seen[nr, nc]){
                                stk.Enqueue(new int[]{nr, nc});
                                seen[nr, nc] = true;
                            }
                        }
                    }
                    ans = Math.Max(ans, shape);
                }
            }
        }
        return ans;
    }
}