public class Solution {
      public IList<IList<int>> res =  new List<IList<int>>();

        public IList<IList<int>> CombinationSum(int[] candidates, int target){
            // Recursive approach 
            RecursiveDp(candidates, candidates.Length, target, new List<int>());
           return res;
        }

        private void RecursiveDp(int[] candidates, 
            int length, int target, IList<int> curr){

            if (target == 0){
                res.Add(curr.ToList());
                return;
            }

            if (length <= 0 || target <= 0) return;

            RecursiveDp(candidates, length, 
                    target - candidates[length - 1], 
                    curr.Append(candidates[length - 1]).ToList());
            RecursiveDp(candidates, length -1, target, curr);
        }
}