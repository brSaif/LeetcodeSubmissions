public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var visited = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            var rest = target - nums[i];

            if(visited.ContainsKey(rest))
                return new int[]{visited[rest], i};

            visited[nums[i]] = i;
        }

        return new int[]{};
    }
}