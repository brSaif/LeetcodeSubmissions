public class Solution {
    
    List<int> res = new();
    
    public int[] NumsSameConsecDiff(int n, int k) {
        
        for(int ans = 1; ans < 10; ans++){ 
            Find(ans, n-1, k); 
        }
        
        return res.ToArray();  
    }
    
    private void Find(int ans, int n, int k){
        
        if(n == 0){
            res.Add(ans);
        }
        
        for(int i = 0; i < 10; i++){
            if(Math.Abs(ans%10-i) == k) 
                Find(ans*10+i, n-1, k);
        }
        ans /= 10; 
    }
}