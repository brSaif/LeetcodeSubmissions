public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> strSet = new HashSet<string>();
        for(int i = 0; i < 9; i++){
            for(int j = 0; j < 9; j++){
                char currVal = board[i][j];
                if(currVal != '.'){
                    if(!strSet.Add(board[i][j] + " found in row "+ i)
                    || !strSet.Add(board[i][j] + " found in column "+ j)
                    || !strSet.Add(board[i][j] + " found in sub grid "+ i/3 +" "+ j/3)) return false;
                }
            }
        }
        
        return true;
     
    }
}