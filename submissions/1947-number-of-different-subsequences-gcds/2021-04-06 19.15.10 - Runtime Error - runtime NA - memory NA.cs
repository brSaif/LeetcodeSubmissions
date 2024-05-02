public class Solution {
    public int CountDifferentSubsequenceGCDs(int[] nums) {
        
        int len = nums.Length;
        int[] gcdList = new int[200000];
        
        for(int i =0; i < len ; i++){
            int n = nums[i];
            int m = (int) Math.Sqrt(n);
            for(int g = 1; g <= m ; g++){
                if(n % g != 0) continue;
                int x = g, y = n/g;
                if(x != y){
                    gcdList[x] = gcd(n, gcdList[x]);
                    gcdList[y] = gcd(n, gcdList[y]);
                }else{
                    gcdList[x] = gcd(n, gcdList[x]);
                }
            }
        }
        
        int cnt = 0;
        for(int i=1; i < gcdList.Length; i++){
            if(gcdList[i] == i ) cnt++;
        }
        
        return cnt;
    }
    
    private int gcd(int a, int b){
        while(b != 0){
            int t = b;
            b = a % b;
            a = t;
        }
        
        return a;
    }
}