public class Solution {
    public int[] PlusOne(int[] digits) {
        if(digits.Length == 0) return digits;
        
        Array.Reverse(digits);
        digits[0] += 1;
        if(digits[0] >= 10){
            IList<int> nums = new List<int>(digits);
            nums[0] = 1;
            nums.Reverse();
            nums.Add(0);
            return nums.ToArray();
            }
        Array.Reverse(digits);
        return digits;
    }
}