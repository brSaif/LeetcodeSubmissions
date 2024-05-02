public class Solution {
    
    public int CountDifferentSubsequenceGCDs(int[] nums) {
        
        int count = 0;
        bool[] bitmap = new bool[2000001];
        int max = 0;
        
        foreach(int n in nums)
        {
            max = Math.Max(max, n);
            bitmap[n] = true;
        }
        
        for (int i = 1; i <= max; i++)
        {
            int d = 0;
            for (int x = i; d != i && x <= max; x+=i)
            {
                if (bitmap[x]) d = getGCD(d, x);
            }
            
            if (d == i) count++;
        }
        
        return count;
    }
    
    int getGCD(int a, int b)
    {
        if (b == 0)
            return a;
    
        return getGCD(b, a % b); 
    }
}