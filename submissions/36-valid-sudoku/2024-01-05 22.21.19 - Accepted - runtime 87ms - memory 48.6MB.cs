public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var seen = new HashSet<string>();

        for(int i = 0; i < 9; i++)
        {
            for(int j = 0; j < 9; j++){
                if(!char.IsDigit(board[i][j]))
                    continue;

                if(!seen.Add($"{board[i][j]} exist in row {i}")
                    || !seen.Add($"{board[i][j]} exist in column {j}")
                    || !seen.Add($"{board[i][j]} exist in grid {i / 3}-{j / 3}"))
                    return false;
            }
        }

        return true;
    }
}