public class Solution {
    public int MaxDistToClosest(int[] seats) {
        
        int res = 1, len = seats.Length;
        int prev = -1, future = 0;
        for ( int i =0; i < len; i++){
            if(seats[i] == 1) prev = i;
            else {
                while (future  < len && seats[future] == 0 || future < i)
                    future ++;
                int left = prev == -1 ? len : i - prev;
                int right = future == len ? len : future - i;
                res = Math.Max(res, Math.Min(left, right));
            }
        }
        
        return res;
    }
}