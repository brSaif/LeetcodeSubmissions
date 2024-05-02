public class Solution {
    public int DeleteAndEarn(int[] nums) {
        int[] count = new int[10001];
        
        foreach (var num in nums)
            count[num] += num;
        
        int prev = 0, curr = 0, next = 0;
        for (int i = 0; i < 10001; i++){
            next = Math.Max(prev + count[i], curr);
            prev = curr;
            curr = next;
        }
        
        return next;
    }
}