public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
          // Start with all numbers from right side
        var result = cardPoints.Skip(cardPoints.Count() - k).Take(k).Sum();
        
        var possibleResult = result;
        for(int i = 0; i < k; i++){
            possibleResult = possibleResult + cardPoints[i] - cardPoints[cardPoints.Count() - k + i];
            result = Math.Max(result, possibleResult);
        }
        return result;
        
    }
}