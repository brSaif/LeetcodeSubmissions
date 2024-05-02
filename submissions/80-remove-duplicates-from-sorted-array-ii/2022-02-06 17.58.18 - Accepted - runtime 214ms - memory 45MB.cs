public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var numsTransform = nums.GroupBy(x => x).SelectMany(g => g.Take(2)).ToArray();
        
        Array.Copy(numsTransform, nums, numsTransform.Length);
        return numsTransform.Length;
    }
}