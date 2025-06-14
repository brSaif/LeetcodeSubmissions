public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        if(triangle == null || triangle.Count == 0) return 0;
                
        for(int i = triangle.Count-1; i >0; i--){
            for(int j = 0; j < i;j++){
                triangle[i-1][j] = Math.Min(triangle[i][j], triangle[i][j+1]) 
                    + triangle[i-1][j];
            }            
        }
        return triangle[0][0];
    }
}