public class Solution {
    private IList<IList<int>> res = new List<IList<int>>();
	public IList<IList<int>> Subsets(int[] nums) {
		Helper(nums.ToList(), new List<int>(), 0);
		return res;
	}

	private void Helper(IList<int> nums, IList<int> choose, int startIndex)
	{
		res.Add(new List<int>(choose));

		for(var i = startIndex; i < nums.Count; i++)
		{
			choose.Add(nums[i]);
			Helper(nums, choose,i + 1);
			choose.RemoveAt(choose.Count-1);
		}
	}
}