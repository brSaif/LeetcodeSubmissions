public class Solution {
    public int CountOperations(int num1, int num2) {
        if (num1 == num2 && num1 == 0) return 0;
        return Helper(num1, num2);
    }
    private int Helper(int num1, int num2){
        
        int min = Math.Min(num1, num2);
        int max = Math.Max(num1, num2);
        int diff = max - min;
        if (diff == 0) return 1;
        return Helper(min, diff) + 1; 
    }
}