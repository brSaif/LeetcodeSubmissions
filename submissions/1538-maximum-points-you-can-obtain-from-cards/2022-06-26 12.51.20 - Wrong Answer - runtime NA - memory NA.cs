public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
     
        int currMin = int.MaxValue;;
        int take = cardPoints.Length - k;
        int sum = cardPoints.Sum();
        for (int i = 0; i < cardPoints.Length - take ; i++){
           var tmp = cardPoints.Skip(i).Take(take).Sum();
            currMin = Math.Min(currMin, tmp);
        }
        
        return sum - currMin;
        
    }
}