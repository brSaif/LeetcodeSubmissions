public class Solution {
     public IList<IList<int>> ShiftGrid(int[][] grid, int k)
    {
        int r = grid.Length, c = grid[0].Length;
        for(int count = 0; count < k; count++)
        {
            for(int i = 0; i < r; i++)
            {
                ShiftOne(grid[i], 0, c - 2);
                ShiftOne(grid[i], c - 1, c - 1);
                ShiftOne(grid[i], 0, c - 1);
            }
            
            var temp = grid[r - 1][0];
            for(int i = r - 1; i > 0; i--)
                grid[i][0] = grid[i - 1][0];
            grid[0][0] = temp;
        }
        
        return grid;
    }
    
    private void ShiftOne(int[] arr, int start, int end)
    {
        while(start < end)
        {
            var temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }
}