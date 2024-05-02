public class Solution {
    public void Rotate(int[][] matrix) {
        int len = matrix.GetLength(0);
        Transpose(matrix, len);
        Reverse(matrix, len);
    }
    
    public void Transpose(int[][] matrix,int n){
        for(int i = 0;  i < n; i++){
            for(int j=0; j < n; j++){
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
    }
    
    public void Reverse(int[][] matrix, int n){
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n/2; j++){
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][n - j -1];
                matrix[i][n - j -1] = temp;
            }
        }
    }
}