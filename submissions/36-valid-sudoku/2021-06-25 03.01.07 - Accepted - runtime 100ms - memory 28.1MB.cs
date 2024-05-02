public class Solution {
    public bool IsValidSudoku(char[][] board) {
       int row = board.Length;
        int col = board[0].Length;
        
        if(row != 9 || col != 9) return false;
        
        for(int i = 0; i < 9; i++)
        {
            if(!IsUnique(board, i, 0, i, 8))
                return false;
            
            if(!IsUnique(board, 0, i, 8, i))
                return false;
        }
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (!IsUnique(board, i * 3, j * 3, i * 3 + 2, j * 3 + 2))
                    return false;
            }
        }
        
        return true;
    }
    
    private bool IsUnique(char[][] board, int x1, int y1, int x2, int y2)
    {
        HashSet<char> set = new HashSet<char>();
        for(int i = x1; i <= x2 && i < 9; i++)
        {
            for(int j = y1; j <= y2 && j < 9; j++)
            {
                if (board[i][j] != '.' && !set.Add(board[i][j]))
                    return false;
            }
        }        
        return true;
    }
}