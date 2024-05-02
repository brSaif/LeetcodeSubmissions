public class Solution {
    public int FindMaxLength(int[] nums) {
        int max = 0;
        Dictionary<int, int> dict = new();
        dict.Add(0, -1);
        int sum = 0;
        nums = nums.Select(x => x == 0 ? -1 : x).ToArray();
        for (int i = 0; i < nums.Length; ++i) 
        {
            sum += nums[i];
            if (dict.ContainsKey(sum)) 
            {
                max = Math.Max(max, i - dict[sum]);
            }
            else 
            {
                dict.Add(sum, i);
            }
        }
        return max;
    }
}