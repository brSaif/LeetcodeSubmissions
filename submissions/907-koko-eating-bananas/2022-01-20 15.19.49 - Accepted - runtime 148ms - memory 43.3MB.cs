public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 0, r = 1_000_000_000;
		
        while (l + 1 < r) 
        {
            int m = (l + r) / 2;
            
            if (piles.Select(pile => (pile + m - 1) / m).Sum() <= h)
                r = m;
            else
                l = m;
        }
        return r;
    }
}