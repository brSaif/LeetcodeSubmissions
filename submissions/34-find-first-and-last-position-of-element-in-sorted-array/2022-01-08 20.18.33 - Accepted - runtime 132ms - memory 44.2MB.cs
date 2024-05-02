public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        
        int start = 0, end = 0, index = 0;
        var seen = nums.ToDictionary(x => index++,x => x)
            .Where(x => x.Value == target);
        if (seen.Any()) {
            start = seen.First().Key;
            end = seen.Last().Key;
        }
        else{
            start = -1;
            end = -1;
        }
        return  new int[2]{start,end};
    }
}