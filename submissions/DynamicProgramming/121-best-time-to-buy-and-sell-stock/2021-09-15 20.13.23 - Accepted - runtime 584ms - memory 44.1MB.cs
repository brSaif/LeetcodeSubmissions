public class Solution {
    public int MaxProfit(int[] prices) {
        int minBuy = int.MaxValue;
        int maxProfit = 0;
        foreach(var n in prices){
            if(n < minBuy) minBuy = n;
            else maxProfit = Math.Max(maxProfit,n - minBuy);
        }
        return maxProfit;
    }
}