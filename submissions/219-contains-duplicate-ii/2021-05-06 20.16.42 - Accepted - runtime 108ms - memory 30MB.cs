public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        // A dictionary takes value as a key and the index as value
        IDictionary<int,int> items = new Dictionary<int,int>();
        
        for(int i = 0; i < nums.Length ; i++){
            if(items.ContainsKey(nums[i])){
                // Return True if condition verified
                if(Math.Abs(i - items[nums[i]]) <= k) return true;
                
                // Otherwise Update index value in the dictionary
                items[nums[i]] = i;
            }
            else{
                items.Add(nums[i],i);
            }
            
        }
        return false;
    }
}