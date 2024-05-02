public class Solution {
    public int[] CountBits(int n) {
        
        int[] res = new int[n + 1];
        
        for (int i = 0; i <= n; i++){
            res[i] = Solve(i);
        }
        
        return res;
    }
    
    private int Solve(int n){
        if (n == 0) return 0;
        if (n == 1) return 1;
        return n % 2 == 0 ? Solve(n / 2) : 1 + Solve(n/2);
    }
}