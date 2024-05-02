public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new HashSet<string>();
        int len = board.GetLength(0);
        for(int i = 0; i < len ; i++){
            for(int j = 0; j < len; j++){
                char currElem = board[i][j];
                if(currElem != '.'){
                    if(!seen.Add(currElem + " found in row "+ i) ||
                      !seen.Add(currElem + " founf in column "+ j) ||
                      !seen.Add(currElem + " found in sub grid " + i/3 +"-"+j/3)) return false;
                }
            }
        }
        return true;
    }
}