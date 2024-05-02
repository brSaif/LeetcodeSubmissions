public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        if(nums.Length <= 1) return new int[]{};

        var visitedNumbers = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var temp = target - nums[i];
            
            if(visitedNumbers.ContainsKey(temp) 
                && nums[temp] != i)
            {
                return new int[]{i,visitedNumbers[temp]};
            }else if(visitedNumbers.ContainsKey(nums[i])){
                visitedNumbers[nums[i]] +=1 ;
            }
            else
            {
                visitedNumbers.Add(nums[i],i);
            }

        }

        return new int[]{};
    }
}