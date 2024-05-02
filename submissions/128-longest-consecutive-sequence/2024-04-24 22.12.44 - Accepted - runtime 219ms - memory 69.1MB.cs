public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = nums.ToHashSet();
        var dict = new Dictionary<int, int>();
        var res = 0;

        foreach (var n in nums){
            if (set.Contains(n - 1))
                continue;

            var count = 1;
            if (dict.ContainsKey(n))
                count = dict[n];
            else {
                var tmp = n + 1;
                while (set.Contains(tmp))
                {
                    tmp++;
                    count++;
                }

                dict.Add(n, count);
                res = res > count ? res : count;
            }
        }

        return res;

    }
}