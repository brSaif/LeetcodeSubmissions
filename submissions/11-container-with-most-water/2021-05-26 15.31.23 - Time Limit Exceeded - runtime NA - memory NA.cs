public class Solution {
    public int MaxArea(int[] height) {
        int Area = 0;
     
        for(int i = 0; i < height.Length; i++)
        {
            for(int j = i + 1; j < height.Length; j++)
            {
                Area = Math.Max(Area, Math.Min(height[i], height[j]) * (j - i));
            }
        }
        return Area;
    }
}