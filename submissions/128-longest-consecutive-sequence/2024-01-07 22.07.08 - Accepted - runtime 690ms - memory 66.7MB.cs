public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = nums.ToHashSet();
        int res = 0;
        foreach(var n in nums){
            if (set.Contains(n -1))
                continue;
            var tmp = n + 1;
            var count = 1;
            while (set.Contains(tmp))
            {
                count++;
                tmp++;
            }
            res = res > count ? res : count;            
        }

        return res;
    }
}