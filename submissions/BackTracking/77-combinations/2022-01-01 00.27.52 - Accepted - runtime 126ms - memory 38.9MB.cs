public class Solution {
     private List<IList<int>> result = new List<IList<int>>();
    
    public IList<IList<int>> Combine(int n, int k) {
        var nums = new int[k];        
        Generate(nums, 1, 0, n, k);
        return result;        
    }
       
    private void Generate(int[] nums, int startNumber, int depth, int n, int k) {
        if (depth == k) {
            result.Add(nums.ToArray());
            return;
        }
        
        for (int current = startNumber; current <= n ; ++current) {
            nums[depth] = current;        
            Generate(nums, current + 1, depth + 1, n, k);
        }
    }  
}