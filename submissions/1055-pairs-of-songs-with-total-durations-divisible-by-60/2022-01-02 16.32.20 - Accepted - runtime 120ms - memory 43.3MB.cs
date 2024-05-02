public class Solution {
    public int NumPairsDivisibleBy60(int[] time) {
        var seen = new int[60];
        int res = 0;
        foreach (int c in time){
            int t = c % 60;
            res += seen[(60 - t) % 60];
            seen[t]++;
        }
        return res;
    }
}