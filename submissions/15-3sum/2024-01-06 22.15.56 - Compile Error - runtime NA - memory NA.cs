public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> res = new();
        int left, right;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i ++)
        {
            if (i > 0 && (nums[i] == nums[i - 1]))
                continue;
            
            left = i + 1;
            right = nums.Length - 1;

            while(left < right)
            {
                if (nums[i] + nums[left] + nums[right] > 0)
                    right--;
                else if (nums[i] + nums[left] + nums[right])
                    left++;
                else {
                    left++
                    res.Add(new List<int>(){nums[i], nums[left], nums[right]});
                    while(left < right && nums[left] == nums[left - 1])
                        left++
                }

            }
        }
        return res;
    }
}