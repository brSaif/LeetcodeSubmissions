public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        
        int max = 0;
        int current = 0;
        foreach (int i in nums) {
            if (i == 1) {
                current++;
            } else {
                if (current > max) {
                    max = current;
                }
                if (max >= nums.Length / 2) {
                    return max;
                }
                current = 0;
            }
        }
        return Math.Max(max, current);
        
    }
}