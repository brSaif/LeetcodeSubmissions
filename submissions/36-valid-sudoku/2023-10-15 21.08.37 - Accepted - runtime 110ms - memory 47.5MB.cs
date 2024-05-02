public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new();

        for(int i = 0; i < 9; i++){
            for (int j = 0; j < 9; j++){
                if(Char.IsNumber(board[i][j])
                    && (!seen.Add($"{board[i][j]} exists in row {i}")
                    || !seen.Add($"{board[i][j]} exists in column {j}")
                    || !seen.Add($"{board[i][j]} exists in grid {i/3}-{j/3}"))                )
                    return false;
            }
        }

        return true;
    }
}