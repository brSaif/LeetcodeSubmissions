public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        if (nums.Length < 1) return new int[]{};
        
        var values = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++){
            int tmp = target - nums[i];
            if (values.ContainsKey(tmp) && values[tmp] != i)
                return new int[]{values[tmp], i};
            else if (values.ContainsKey(tmp))
                values[nums[i]] = i; 
            else
                values.Add(nums[i], i);
        }
        Console.Write("----");
        return new int[]{};
    }
}