public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var res  = new List<IList<int>>();
        dfs (new List<int>(), new bool[nums.Length], res, nums);
        return res;
    }
    
    private void dfs (List<int> path, bool[] used, List<IList<int>> result, int[] nums){
        if (path.Count == used.Length){
            result.Add(new List<int> (path));
            return;
        }
        
        for (int i = 0; i < used.Length; i++){
            if (used[i]) continue;
            
            path.Add(nums[i]);
            used[i]  = true;
            
            dfs (path, used, result, nums);
            
            path.RemoveAt(path.Count - 1);
            used[i] = false;
        }
    }
}