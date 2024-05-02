public class Solution {
    public int FindMaxLength(int[] nums) {
        var map = new Dictionary<int,int>();
    	int maxlen = 0, count = 0;
    	for(int i = 0;i < nums.Length;i++) {
    		count += (nums[i] == 1)?1:-1;
                // Array from index 0 to i contains equal number of 0's and 1's
    		if(count == 0)
    			maxlen = Math.Max(maxlen, i+1);    		
    		if(map.ContainsKey(count)) {
    			maxlen = Math.Max(maxlen, i - map[count]);
    		} else 
    			map.Add(count, i);
    	}
    	return maxlen;
    }
}