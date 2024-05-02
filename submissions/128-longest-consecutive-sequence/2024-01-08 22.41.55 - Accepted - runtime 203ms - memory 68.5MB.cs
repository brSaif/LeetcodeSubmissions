public class Solution {
    public int LongestConsecutive(int[] nums) {
        var res = 0;
        var set = nums.ToHashSet();
        var dict = new Dictionary<int, int>();
        foreach(var n in nums){
            if (set.Contains(n - 1))
                continue;
            var count = 1;
            var tmp = n + 1;
            if (dict.ContainsKey(n))
                count = dict[n];
            else{
                while (set.Contains(tmp))
                {
                    count++;
                    tmp++;
                }
                dict.Add(n, count);
            }
            
            res = res < count ? count : res;
        }
        return res;
    }
}