public class Solution {
    
    // Overall time complexity O(2n^2) = O(n^2)
    public void Rotate(int[][] matrix) {
        int n = matrix.GetLength(0);
        reverseDiag(matrix,n);
        reverseHorizontal(matrix,n);
    }
    
    // O(n^2) time complexity
    public void reverseDiag(int[][] matrix, int n){
        for(int i = 0; i < n; i++){
            for(int j = i; j < n; j++){
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
    }
    
    public void reverseHorizontal(int[][] matrix,int n){
        for(int i = 0;i < n ;i++){
            for(int j = 0 ; j < n/2; j++){
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][n - j - 1];
                matrix[i][n - j - 1] = temp;
            }
        }
    }
}