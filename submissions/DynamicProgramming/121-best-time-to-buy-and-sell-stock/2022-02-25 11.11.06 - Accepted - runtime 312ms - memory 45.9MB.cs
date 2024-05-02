public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length < 2 ) return 0;
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        foreach (var c in prices){
            minPrice = Math.Min(minPrice, c);
            maxProfit = Math.Max(maxProfit, c - minPrice);
        }
        return maxProfit;
    }
}