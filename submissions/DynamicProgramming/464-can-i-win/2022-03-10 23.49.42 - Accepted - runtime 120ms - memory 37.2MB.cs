public class Solution {
       public bool CanIWin(int maxChoosableInteger, int desiredTotal) {
        if(desiredTotal<=0) return true;
       int[] dp=new int[1<<maxChoosableInteger];
         if (maxChoosableInteger * (maxChoosableInteger + 1) / 2 < desiredTotal) return false;
        return canWin(maxChoosableInteger,desiredTotal,0,dp);
    }
    public bool canWin(int m,int t,int ch,int []dp){

        if(t<=0){
            dp[ch]=-1;
            return false;
        }
        if(dp[ch]!=0) return dp[ch]==1;
        
        for(int i=0;i<m;i++){
            if((ch&(1<<i))!=0) continue;

            if(!canWin(m,t-i-1,ch|(1<<i),dp))
            {
                dp[ch]=1;
                return true;
            }
            
        }
        dp[ch]=-1;
        return false;
    }
}