public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0, right = prices.Length - 1;
        int maxProfit = 0;

        while (left < right){
            while (prices[left] > prices[right] && left < right)
            {
                left++;
            }
            var tmp = prices[right] - prices[left];
            if (tmp > 0){
                maxProfit = Math.Max(maxProfit, tmp);
                right--;
            }
        }

        return maxProfit;
    }
}