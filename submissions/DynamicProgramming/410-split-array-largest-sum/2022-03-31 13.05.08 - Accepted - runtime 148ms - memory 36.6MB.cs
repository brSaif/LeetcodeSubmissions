public class Solution {
    
    public int SplitArray(int[] nums, int m) {
        int sum = nums.Sum();
        int max = nums.Max();
        return binary(nums, m, sum, max);
    }
    private int binary(int[] nums, int m, int high, int low) {
        while (low <= high) {
            int mid = low + (high - low) / 2;
            if (valid(nums, m, mid)) 
                high = mid - 1; 
            else 
                low = mid + 1;
        }
        return low;
    }
    
    private bool valid(int[] nums, int m, int subArraySum) {
        int curSum = 0;
        int count = 1;
        foreach (int num in nums) {
            curSum += num;
            if (curSum > subArraySum) {
                curSum = num;
                count++;          
                if (count > m)
                    return false;
            }
        }
        return true;
    }
}