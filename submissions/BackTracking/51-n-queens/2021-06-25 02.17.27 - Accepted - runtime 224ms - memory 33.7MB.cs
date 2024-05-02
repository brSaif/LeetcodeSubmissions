public class Solution {
    
    public HashSet<int> colsSet = new HashSet<int>();
    public HashSet<int> posDiagSet = new HashSet<int>();  // (r + c)
    public HashSet<int> negDiagSet = new HashSet<int>();  // (r - c)
        
    public IList<IList<string>> SolveNQueens(int n) {
        
        IList<IList<string>> res = new List<IList<string>>();
        char[][] board = new char[n][];
        for(int i = 0; i < n ; i++){
            board[i] = new char[n];
            Array.Fill(board[i],'.');
        }
        
        backTrack(board,0,res);
        return res;  
    }
    
    public void backTrack(char[][] board,int row,IList<IList<string>> res){
        if(row == board.GetLength(0)){
            IList<string> list = new List<string>();
            for(int i = 0; i < board.GetLength(0);i++){
                string s = new string(board[i]);
                list.Add(s); 
            }
            res.Add(list);
            return;
        }
        
        for(int col = 0; col < board.GetLength(0);col++){
            if(colsSet.Contains(col) ||
              posDiagSet.Contains(row + col) ||
              negDiagSet.Contains(row - col)) continue;
            
            colsSet.Add(col);
            posDiagSet.Add(row + col);
            negDiagSet.Add(row - col);
            board[row][col] = 'Q';
            
            backTrack(board, row + 1, res);
            
            colsSet.Remove(col);
            posDiagSet.Remove(row + col);
            negDiagSet.Remove(row - col);
            board[row][col] = '.';
            
        } 
    }
}