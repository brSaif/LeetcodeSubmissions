public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] res = new int[2];
        int index = 0;
        var seen = nums.ToDictionary(x => index++, x => x)
            .Where(x => x.Value == target);
        if(seen.Any()){
            res[0] = seen.First().Key;
            res[1] = seen.Last().Key;
        }else{
            res[0] = -1;
            res[1] = -1;
        }
        return res;
    }
}