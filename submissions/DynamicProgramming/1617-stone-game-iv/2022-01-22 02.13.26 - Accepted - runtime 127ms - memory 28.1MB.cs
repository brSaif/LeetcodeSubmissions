public class Solution {
    public bool WinnerSquareGame(int n) {

        var dp = new bool[n+1];
        var ps = new List<int>(){1};
        dp[1] = true;
        for (int i = 2; i <= n; i++)
        {
            if (Math.Sqrt(i) % 1 == 0)
            {
                ps.Add(i);
                dp[i] = true;
            }
            else
            {
                foreach (int s in ps)
                {
                    if (!dp[i-s])
                    {
                        dp[i] = true;
                        break;
                    }                    
                }                
            }
        }        
        return dp[n];

    }
}