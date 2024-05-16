public class Solution {
    public int MatrixScore(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        
        // First, toggle rows to ensure the leftmost bit in each row is 1
        for (int i = 0; i < m; i++) {
            if (grid[i][0] == 0) {
                ToggleRow(grid, i);
            }
        }
        
        // Next, toggle columns to maximize each column's score
        for (int j = 1; j < n; j++) {
            int countOnes = 0;
            for (int i = 0; i < m; i++) {
                countOnes += grid[i][j];
            }
            if (countOnes < m - countOnes) {
                ToggleColumn(grid, j);
            }
        }
        
        // Calculate the score
        int score = 0;
        foreach (var row in grid) {
            int rowScore = 0;
            foreach (var bit in row) {
                rowScore = (rowScore << 1) + bit;
            }
            score += rowScore;
        }
        return score;
    }
    private void ToggleRow(int[][] grid, int row) {
        for (int j = 0; j < grid[row].Length; j++) {
            grid[row][j] = 1 - grid[row][j];
        }
    }
    
    private void ToggleColumn(int[][] grid, int col) {
        for (int i = 0; i < grid.Length; i++) {
            grid[i][col] = 1 - grid[i][col];
        }
    }
}