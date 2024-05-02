public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        // A dictionary takes value as a key and the index as value
        IDictionary<int,int> items = new Dictionary<int,int>();
        
        for(int i = 0; i < nums.Length ; i++){
            if(items.ContainsKey(nums[i])){
                if(k >= Math.Abs(items[nums[i]] - i)) return true;
                
            }
            else{
                items.Add(nums[i],i);
            }
            
        }
        return false;
    }
}