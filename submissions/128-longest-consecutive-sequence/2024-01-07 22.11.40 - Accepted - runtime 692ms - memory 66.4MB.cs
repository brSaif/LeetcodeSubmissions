public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = nums.ToHashSet();
        int res = 0;

        foreach(var n in nums){
            if (set.Contains(n - 1))
                continue;
            int count = 1;
            int tmp = n + 1;
            while (set.Contains(tmp))
                {
                    tmp++;
                    count++;
                }
            res = res > count ? res : count;
        }
        return res;
    }
}