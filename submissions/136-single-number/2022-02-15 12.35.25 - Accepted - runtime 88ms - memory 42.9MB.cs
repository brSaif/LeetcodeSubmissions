public class Solution {
    public int SingleNumber(int[] nums) =>
        nums.Aggregate((x, y) => x ^ y);
}