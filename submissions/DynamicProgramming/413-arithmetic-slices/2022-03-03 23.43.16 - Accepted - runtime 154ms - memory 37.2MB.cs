public class Solution {
    public int NumberOfArithmeticSlices(int[] nums) {
        var sequence = 0;
        return nums.Zip(nums.Skip(1), (a, b) => (a, b)).Zip(nums.Skip(2), (t, c) => (t.a, t.b, c))
            .Select(t => t.c - t.b == t.b - t.a ? ++sequence : sequence = 0)
            .Sum();
    }
}