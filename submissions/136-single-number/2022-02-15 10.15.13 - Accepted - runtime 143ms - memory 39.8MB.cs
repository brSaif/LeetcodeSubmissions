public class Solution {
    public int SingleNumber(int[] nums) {
       int b = nums[0];
for (int i = 1;i < nums.Length ; i++)
    b ^= nums[i];

return b;
    }
}