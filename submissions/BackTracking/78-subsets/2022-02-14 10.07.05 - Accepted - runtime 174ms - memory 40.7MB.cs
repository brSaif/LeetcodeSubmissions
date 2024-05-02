public class Solution {
    
    private IList<IList<int>> res = new List<IList<int>>();
    
    public IList<IList<int>> Subsets(int[] nums) {
        Helper(nums.ToList(), new List<int>(), 0);
        return res;
    }
    
    private void Helper (IList<int> nums, IList<int> curr, int startIndex){
        res.Add(new List<int>(curr));
        
        for(int i = startIndex; i < nums.Count; i++){
            curr.Add(nums[i]);
            Helper(nums, curr, i +1);
            curr.Remove(nums[i]);
        }
    }
}