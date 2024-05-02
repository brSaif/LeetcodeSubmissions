public class Solution {
    public int DeleteAndEarn(int[] nums) {
        int[] count = new int[10001];

        foreach(var num in nums)
        {
            count[num] += num;
        }

        int next = 0;
        int previous = 0;
        int current = 0;        

        for(int i = 0; i < 10001; i++)
        {
            next = Math.Max(previous + count[i], current);
            previous = current;
            current = next;
        }

        return next;
    }
}