public class Solution {
    public int MaxArea(int[] height) {
        int Area = 0;
        int l = 0;
        int r = height.Length -1;
        int res = 0;
        // Brute Force Solution
        // for(int i = 0; i < height.Length; i++)
        // {
        //     for(int j = i + 1; j < height.Length; j++)
        //     {
        //         Area = Math.Max(Area, Math.Min(height[i], height[j]) * (j - i));
        //     }
        // }
        // return Area;
        while(l < r){
            res = Math.Min(height[l], height[r]) * (r -  l);
            Area = Math.Max(Area, res);
            
            if(height[l] < height[r]) 
            {
                l += 1;
            }
            else{
                r -= 1;
            }
                    
        }
        
        return Area;  
        
    }
}