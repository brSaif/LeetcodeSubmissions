public class Solution {
    public int MaxProfit(int[] prices) {
        int minBuy = int.MaxValue;
        int maxProfit = 0;
        for(int i = 0; i  < prices.Length; i++){
            if(prices[i] < minBuy){
                minBuy = prices[i];
            }else{
                maxProfit += prices[i] - minBuy;
                minBuy = prices[i];
            }
        }
        return maxProfit;
    }
}