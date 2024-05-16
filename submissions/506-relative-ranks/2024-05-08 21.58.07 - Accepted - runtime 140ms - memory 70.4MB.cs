public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        var scoreDict = new Dictionary<int,int>();
        //store the indices and the values in the dictionary
        for(int i = 0; i<score.Length;i++){
            scoreDict[score[i]] = i;
        }
        ///sort the input array in descending order
        Array.Sort(score,(x,y)=>y.CompareTo(x));
        string[] result = new string[score.Length];
        // traverse from 0 to input length to store the ranks
        for(int i = 0;i<score.Length;i++){
            //assign rank based on the position after the sorting
            if(i == 0){
                result[scoreDict[score[i]]] = "Gold Medal";
            }
            else if(i == 1){
                result[scoreDict[score[i]]] = "Silver Medal";
            }
            else if(i == 2){
                result[scoreDict[score[i]]] = "Bronze Medal";
            }
            else{
                result[scoreDict[score[i]]] = (i+1).ToString();
            }
        }
        return result;
    }
}