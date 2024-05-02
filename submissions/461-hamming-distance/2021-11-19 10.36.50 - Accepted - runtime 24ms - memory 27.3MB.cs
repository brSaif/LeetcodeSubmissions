public class Solution {
    public int HammingDistance(int x, int y) {
           
        int m = (x>y)?x:y;
        int l = (int)Math.Log(m,2);
        int count = 0;
        
        for (int i=l; i>=0; i--)
        {
            int pow = (int)Math.Pow(2,i);
            
            if((x>=pow)!=(y>=pow))
                count++;
            if (x>=pow)
                x-=pow;
            if (y>=pow)
                y-=pow;
        }
        return count;
    }
}