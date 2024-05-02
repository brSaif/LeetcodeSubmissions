class Solution {
    public void backtrack (int[] nums, int index, List<Integer> list, List<List<Integer>> answer) {
        
        answer.add (new ArrayList<> (list));
        
        for (int i = index; i < nums.length; i++) {
            if (i != index && nums[i - 1] == nums[i]) {
                continue;
            }
            
            list.add (nums[i]);
            backtrack (nums, i + 1, list, answer);
            list.remove (list.size () - 1);
        }
    }
    
    public List<List<Integer>> subsetsWithDup(int[] nums) {
        
        List<List<Integer>> answer = new ArrayList<> ();
        
        Arrays.sort (nums);
        backtrack (nums, 0, new ArrayList<> (), answer);
        
        return answer;
    }
}