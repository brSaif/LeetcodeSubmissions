public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var list = nums.GroupBy(x => x).SelectMany(x => x.Take(2)).ToArray();
        Array.Copy(list, nums, list.Length);
        return list.Length;
    }
}