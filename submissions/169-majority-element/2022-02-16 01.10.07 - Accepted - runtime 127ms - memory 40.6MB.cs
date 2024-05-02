public class Solution {
    public int MajorityElement(int[] nums) 
        => nums.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
        

}