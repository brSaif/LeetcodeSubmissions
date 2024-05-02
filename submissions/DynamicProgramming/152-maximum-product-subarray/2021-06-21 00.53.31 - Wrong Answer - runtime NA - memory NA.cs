public class Solution {
    public int MaxProduct(int[] nums) {
        int res = 0;
        int currMin = 1;
        int currMax = 1;
                
        foreach(var n in nums){
            int temp = currMin * n;
            currMin = Math.Min(Math.Min(currMin * n, currMax * n),n);
            currMax = Math.Max(Math.Max(temp, currMax * n),n);
            res = Math.Max(Math.Max(res, currMax),n);
        }
        
        return res;
    }
}