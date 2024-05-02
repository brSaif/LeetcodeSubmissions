public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        
        int maxConsecutive = 0;

            for (int i = 0; i < nums.Length -1; i++)
            {
                if (nums[i] == 1)
                {
                    int localMaxConsecutive = 1;
                    while (nums[i] == nums[i + 1] && i < nums.Length -2)
                    {
                        localMaxConsecutive++;
                        i++;
                    }

                    if(maxConsecutive < localMaxConsecutive)
                        maxConsecutive = localMaxConsecutive;
                }

                i++;
            }
            return maxConsecutive;
    }
}