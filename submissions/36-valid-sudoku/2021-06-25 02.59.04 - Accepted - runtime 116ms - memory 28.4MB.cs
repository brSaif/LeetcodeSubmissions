public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new HashSet<string>();
        
        for(int i = 0; i < 9; i++){
            for(int j = 0;j < 9;j++){
                char currVal = board[i][j];
                if(currVal != '.'){
                    if(!seen.Add(currVal + "found in row "+ i) ||
                       !seen.Add(currVal + "found in column "+ j) ||
                       !seen.Add(currVal + "found in sub box "+ i/3 +"-"+j/3))return false;
                }
            }
        }
        
        return true;
    }
}