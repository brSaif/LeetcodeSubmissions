public class Solution {
    public int MaxArea(int[] height) {
        int res = 0;
        int left = 0;
        int right = height.Length -1;
        while(left < right){
            int currMax = Math.Min(height[left],height[right]) * (right - left);
            res = Math.Max(res,currMax);
            if(height[left] <= height[right]){
                left ++;
                continue;
            }
            right --;
        }
        return res;
    }
}