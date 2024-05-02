public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> res = new ();
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 2; i++){
            int left = i + 1;
            int right = nums.Length - 1;
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            while(left < right){
                if(nums[left] + nums[right] + nums[i] > 0)
                    right--;
                else if (nums[left] + nums[right] + nums[i] < 0)
                    left++;
                else{
                    res.Add(new List<int>(){nums[i], nums[left], nums[right]});
                    left++;
                    while(nums[left] == nums[left - 1] && left < right)
                        left++;
                }
            }
        }
        return res;
    }
}