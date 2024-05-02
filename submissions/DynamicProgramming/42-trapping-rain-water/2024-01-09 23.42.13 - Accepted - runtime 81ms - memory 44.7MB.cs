public class Solution {
    public int Trap(int[] height) {
        int res = 0;
        int left = 0;
        int right = height.Length - 1;
        int leftMax = height[left];
        int rightMax = height[right];
        while(left < right){
            if(leftMax > rightMax){
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                res += rightMax - height[right];
            }else{
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                res += leftMax - height[left];
            }
        }
        return res;
    }
}