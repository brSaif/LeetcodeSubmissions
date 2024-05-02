public class Solution {
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) 
         =>
    nums1.SelectMany(a => nums2.Select(b => a + b)).GroupBy(s => s).Join(
    nums3.SelectMany(c => nums4.Select(d => c + d)).GroupBy(s => s),
    g => g.Key, g => -g.Key,
    (x, y) => x.Count() * y.Count()).Sum();
    
}