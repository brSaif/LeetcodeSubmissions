public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int[] res = new int[nums.Length - k  + 1];
        int left = k;
        int right = nums.Length - 1;
        int index = 0;

        for (int i = 0; i < k; i++){
            res[0] = Math.Max(res[0], nums[i]);
        }

        while (left <= right)
        {
            index++;
            res[index] = Math.Max(res[index - 1], nums[left]);
            left++;
        }

        return res;
    }
}