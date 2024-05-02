public class Solution {
    public int[] PlusOne(int[] digits) {
        if(digits.Length == 0) return digits;
        
        Array.Reverse(digits);
        digits[0] += 1;
        Array.Reverse(digits);
        return digits;
    }
}