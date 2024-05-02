public class Solution {
    public int MaxProfit(int[] prices) {
        int minProfit = Int32.MaxValue;
        int maxProfit = 0;
        
        for(int i = 0; i < prices.Length -1 ; i++){
            if(prices[i] <= prices[i+1]){
                if(prices[i] <= minProfit)  minProfit = prices[i] ;
                if(prices[i + 1] >= maxProfit)  maxProfit = prices[i + 1] ;
            }
        }
        
        if(maxProfit - minProfit > 0){ return maxProfit - minProfit; } 
        return 0;
    }
}