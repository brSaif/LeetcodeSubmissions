public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length <= 1) {
            return 0;
        }
        
        int accumulatedProfit = 0;
        int currentPrice = prices[0];
        
        for (int i = 1; i < prices.Length; i++) {
            if (prices[i] > currentPrice) {
                accumulatedProfit += prices[i] - currentPrice;
                currentPrice = prices[i];
            } else {
                currentPrice = prices[i];
            }
        }
        
        return accumulatedProfit;
    }
}