public class Solution {
    public int MaxArea(int[] height) {
        int res = 0;
        int high = height.Length -1;
        int low = 0;
        while (high > low){
            var currArea = (high - low) * Math.Min(height[high], height[low]);
            res = res > currArea ? res: currArea;
            if (height[low] < height[high])
                low++;
            else 
                high--;
        }
        return res;
    }
}