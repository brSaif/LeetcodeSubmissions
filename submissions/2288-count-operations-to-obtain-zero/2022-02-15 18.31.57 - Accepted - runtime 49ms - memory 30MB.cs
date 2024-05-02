public class Solution {
    public int CountOperations(int num1, int num2) {
        if (num1 == num1 && num1 == 0) return 0;
        return Helper(num1, num2);
    }
    
    private int Helper (int num1, int num2){
        var (min, max) = (Math.Min(num1, num2), Math.Max(num1, num2));
        if (min == 0) return 0;
        int diff = max - min;
        return Helper(min, diff) + 1;
    }
}