public class Solution {
    public int MaxArea(int[] height) {
        int l = 0, r = height.Length -1, res = 0;
        while(l < r){
            int currMax = Math.Min(height[l],height[r]) * (r -l);
            res = Math.Max(res,currMax);
            if(height[l] <= height[r] )  l++ ; else r-- ;
        }
        return res;
    }
}