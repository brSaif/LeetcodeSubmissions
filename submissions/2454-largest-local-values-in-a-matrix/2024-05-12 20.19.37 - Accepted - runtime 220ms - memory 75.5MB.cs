public class Solution {
    public int[][] LargestLocal(int[][] grid) {
        int row = grid.Length - 2;
        int col = grid[0].Length - 2;
        int[][] result = new int[row][];

        for (int i = 0; i < row; i++)
        {
            result[i] = new int[col];

            for (int j = 0; j < col; j++)
            {
                int max = 
                result[i][j] = grid.Skip(i).Take(3).SelectMany(arr => arr.Skip(j).Take(3)).Max();
            }
        }

        return result;
    }
}