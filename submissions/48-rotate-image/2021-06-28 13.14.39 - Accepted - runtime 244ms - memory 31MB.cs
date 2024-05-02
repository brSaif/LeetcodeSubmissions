public class Solution {
    public void Rotate(int[][] matrix) {
        int len = matrix.GetLength(0);
        reverseDiag(matrix,len);
        reverseH(matrix,len);
    }
    
    public void reverseDiag(int[][] matrix, int len){
        for(int i = 0; i < len ; i ++){
            for(int j = i; j < len; j++){
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
    }
    
    public void reverseH(int[][] matrix, int len){
        for(int i = 0; i< len; i++){
            Array.Reverse(matrix[i]);
        }
    }
}