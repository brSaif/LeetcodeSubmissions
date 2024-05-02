public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {

        int rows = mat.Length, cols = mat[0].Length, INF = rows+cols;
        
        for(int r=0; r<rows; r++){
            for(int c=0; c<cols; c++){
                if(mat[r][c] != 0){
                    int top = (r-1 >= 0) ? mat[r-1][c] : INF;
                    int left = (c-1 >= 0) ? mat[r][c-1] : INF;
                    mat[r][c] = Math.Min(top, left) + 1;
                }
            }
        }
        
        for(int r=rows-1; r>=0; r--){
            for(int c=cols-1; c>=0; c--){
                if(mat[r][c] != 0){
                    int bottom = (r+1 < rows) ? mat[r+1][c] : INF;
                    int right = (c+1 < cols) ? mat[r][c+1] : INF;
                    mat[r][c] = Math.Min(mat[r][c], Math.Min(bottom, right)+1);
                }
            }
        }
        
        return mat;
    }
}