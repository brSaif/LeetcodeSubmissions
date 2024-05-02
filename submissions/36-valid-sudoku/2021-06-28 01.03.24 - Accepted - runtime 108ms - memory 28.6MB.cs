public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new HashSet<string>();
        int n = board.Length;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n ; j++){
                char currChar = board[i][j];
                if(currChar != '.'){
                    if(!seen.Add($"{currChar} found in row {i}") ||
                       !seen.Add($"{currChar} found in column {j}") ||
                       !seen.Add($"{currChar} found in sub grid {i/3} - {j/3}")) return false;
                }
            }
        }
        return true;
    }
}