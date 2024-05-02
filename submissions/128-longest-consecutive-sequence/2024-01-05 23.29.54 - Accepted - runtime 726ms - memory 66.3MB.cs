public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        var hashset = nums.ToHashSet();
        int res = 1;

        foreach(var n in nums)
        {
            var count = 1;
            var tmp = n - 1;
            if(hashset.Contains(n - 1)) 
                continue ;

            var tmp2 = n + 1;
            while (hashset.Contains(tmp2))
            {
                count++;
                tmp2++;
            } 

            res = res < count ? count : res;
        }

        return res;
    }
}