public class Solution {
    bool cover = false;   
    public int CountSubIslands(int[][] grid1, int[][] grid2) {
             
        int res = 0;
        for(int i = 0; i < grid2.Length; i++)
        {
            for(int j = 0; j<grid2[0].Length; j++)
            {
                if(grid2[i][j]==1)
                {
                    cover = true;
                    visit(grid1, grid2, i, j);
                    if(cover)
                        res++;
                    cover = false;
                }
             }
        }
        return res;
    }
    
    public void visit(int[][] grid1, int[][]grid2, int i, int j)
    {
        if(i<0||j<0||i>grid1.Length-1||j>grid2[0].Length-1||grid2[i][j]==0)
        {            
            return;
        }   
        
        grid2[i][j] = 0;
        if(grid1[i][j]==0) cover = false;
        
        visit(grid1, grid2, i-1, j);
        visit(grid1, grid2, i+1, j);
        visit(grid1, grid2, i, j-1);
        visit(grid1, grid2, i, j+1);
    }
}