public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int max_divisions = h-piles.Length; // how many piles can be splitted to several hours
    
    Array.Sort(piles);
    
    if(max_divisions==0) // if piles count equals to hours, we must return max bananas in pile count
    {
        return piles[piles.Length-1];    
    }
    
    int left = 1;
    int right = piles[piles.Length-1];
            
    while(left<right)
    {
        int mid = (left+right)/2;
        
        int hours = 0;
        
        for(int i=piles.Length-1;i>=0;i--)
        {
            hours+= (int) Math.Ceiling((double) piles[i]/mid);
            if(hours>h) break; // break if it is already small speed
        }
        
        if(hours<=h) right=mid;    
        else left=mid+1;
    }
    
    return right;
    }
}