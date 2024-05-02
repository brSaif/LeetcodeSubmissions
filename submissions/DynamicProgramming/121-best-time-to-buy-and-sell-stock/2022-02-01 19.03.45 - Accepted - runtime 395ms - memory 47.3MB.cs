public class Solution {
    public int MaxProfit(int[] prices) {
        
        int maxProfit = 0;
        int buyPrice = prices[0];
        
        for (int i = 1; i < prices.Length; i++){
            if (buyPrice > prices[i]) {
                buyPrice = prices[i];
                continue;
            }
            maxProfit = Math.Max(maxProfit, prices[i] -  buyPrice);
            
        }
        
        return maxProfit;
    }
}