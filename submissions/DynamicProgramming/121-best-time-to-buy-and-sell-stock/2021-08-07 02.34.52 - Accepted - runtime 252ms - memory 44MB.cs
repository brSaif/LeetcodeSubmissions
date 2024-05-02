public class Solution {
    public int MaxProfit(int[] prices) {
        int minBuy = int.MaxValue;
        int maxProf = 0;
        for(int i = 0;i < prices.Length; i++){
            if(prices[i] < minBuy) minBuy = prices[i];
            else{
                maxProf = Math.Max(maxProf,prices[i] - minBuy);
            }
        }
        return maxProf;
    }
}