public class Solution {
    private int n;
    public int TotalNQueens(int n) {
        var res = new List<IList<string>>();
        this.n = n;
        char[][] board = new char[n][];
        for(int i =0; i < n; i++)
        {
            board[i] = new char[n];
            Array.Fill(board[i],'.');
        }
        BackTrack(board,0,res);
        return res.Count();
    }
    private void BackTrack(char[][] board, int row, IList<IList<string>> res)
    {
        if(row == n)
        {
            IList<string> list = new List<string>();
            for(int i =0; i < n;i++)
            {
                string s = new string(board[i]);
                list.Add(s);
            }
            res.Add(list);
            return;
        }
        for(int col = 0;col <n;col++)
        {
            if(!isValid(board,row,col)) continue;
            board[row][col]='Q';
            BackTrack(board,row+1,res);
            board[row][col] ='.';
        }
    }
    private bool isValid(char[][] board, int row, int col)
    {
        for(int i = 0; i <row;i++)
        {
            if(board[i][col]=='Q') return false;
        } 
        for(int i = row-1,j = col +1; i >=0 && j <n; i--,j++)
        {
            if(board[i][j]=='Q') return false;
        }    
        for(int i =row -1,j = col -1;i>=0 && j>=0;i--,j--)
        {
            if(board[i][j] =='Q') return false;
        }
        return true;
    }
}