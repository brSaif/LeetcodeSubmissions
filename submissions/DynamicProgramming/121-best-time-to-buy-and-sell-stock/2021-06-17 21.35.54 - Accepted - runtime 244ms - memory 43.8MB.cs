public class Solution {
    public int MaxProfit(int[] prices) {
        
        int minBuy = Int32.MaxValue;
        int maxProfit = 0;
        for(int i = 0; i < prices.Length ; i++){
            minBuy = Math.Min(minBuy, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i] - minBuy);
        }
        
        return maxProfit;
    }
}