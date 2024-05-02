public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new ();
        for (int i = 0; i < 9; i++){
            for (int j = 0; j < 9; j++){
                if (Char.IsNumber(board[i][j]))
                    if (!seen.Add(board[i][j] + "exist in grid"+ i/3 + " " +j/3) 
                        || !seen.Add(board[i][j] + "exist in row"+ i)
                        || !seen.Add(board[i][j] + "exist in  column" + j))
                        return false;
            }
        }
        
        return true;
    }
}