public class Solution {
    public int FindMaximumXOR(int[] nums) {
        
        int currMax = 0;
        int mask = 0;
        
        for(int i = 31; i >=0; i--)
        {
            // get mask at each position
            mask = mask | 1 << i;
            
            // store digits between MSD and i in hashset
            HashSet<int> set = new HashSet<int>();
            foreach(int num in nums)
                set.Add(num & mask);
            
            // check whether can find two numbers such that their XOR result at position i is 1.
            int wishMax = currMax | 1 << i;
            foreach(int n in set)
            {
                if(set.Contains(n ^ wishMax))
                {
                    currMax = wishMax;
                    break;
                }
            }        
        }
        
        return currMax;
    }
}