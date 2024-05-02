public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = nums.ToHashSet();
        int low = 0;
        int res = 0;
        for (int i = 0; i < nums.Length - 1; i++){
           if (set.Contains(nums[i] - 1))
                continue;
            int count = 1;
            int tmp = nums[i] + 1;
            while (set.Contains(tmp))
            {
                count++;
                tmp++;
            }
            res = Math.Max(res, count);
        }
        return res;
    }
}