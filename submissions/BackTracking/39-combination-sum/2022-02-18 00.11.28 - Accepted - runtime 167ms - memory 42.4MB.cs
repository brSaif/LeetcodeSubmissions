public class Solution {
      public IList<IList<int>> res =  new List<IList<int>>();

        public IList<IList<int>> CombinationSum(int[] candidates, int target){
            // Recursive approach 
            RecursiveBacktracking(candidates, 0, target, new List<int>());
           return res;
        }

        private void RecursiveBacktracking(
            int[] candidates, int start, 
            int target, IList<int> curr)
        {
            if (target < 0) return;

            if(target == 0) res.Add(curr.ToList());
            else {
                for (int i = start; i < candidates.Length; i++){
                    curr.Add(candidates[i]);

                    RecursiveBacktracking(candidates, i, target - candidates[i], curr);

                    curr.Remove(curr.LastOrDefault());
                }
            }
        }
}