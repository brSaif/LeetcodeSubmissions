public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        var sortedScores = score.Select((s, i) => Tuple.Create(s, i)).OrderByDescending((s) => s.Item1).ToArray();

        var answer = new string[score.Length];
        for (var i = 0; i < score.Length; i++)
        {
            var rank = (i + 1).ToString();
            if (i == 0) rank = "Gold Medal";
            if (i == 1) rank = "Silver Medal";
            if (i == 2) rank = "Bronze Medal";
            answer[sortedScores[i].Item2] = rank;
        }
        return answer;
    }
}