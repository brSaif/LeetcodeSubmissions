public class Solution {
    private int[][] Tab;
    private int n;
    private int m;
    public int NumEnclaves(int[][] A) {
        Tab=A;
        m=A.Length-1;
        n=A[0].Length-1;
        
        //go around perimeter and mark all walk off areas with 2;
        for(var i=0;i<=m;i++)
        {
             if(A[i][0]==1) MarkArea(i,0,2);
             if(A[i][n]==1) MarkArea(i,n,2);
        }
        for(var j=0;j<=n;j++)
        {
             if(A[0][j]==1) MarkArea(0,j,2);
             if(A[m][j]==1) MarkArea(m,j,2);
        }
        //Count remain 1s
        var cnt=0;
        for(var i=0;i<=m;i++)
        {
            for(var j=0;j<=n;j++)
            {
                if(Tab[i][j]==1) cnt++;
            }
        }
        
        return cnt;
    }
    
    private void MarkArea(int i,int j,int k)
    {
        Tab[i][j]=k;
        if(j>0 && Tab[i][j-1]==1) MarkArea(i,j-1,k);
        if(j<n && Tab[i][j+1]==1) MarkArea(i,j+1,k);
        if(i>0 && Tab[i-1][j]==1) MarkArea(i-1,j,k);
        if(i<m && Tab[i+1][j]==1) MarkArea(i+1,j,k);
        
    }
}