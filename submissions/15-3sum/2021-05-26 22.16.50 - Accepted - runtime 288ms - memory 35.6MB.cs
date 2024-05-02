public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
         if(nums == null || nums.Length < 3)
            return new List<IList<int>>() as IList<IList<int>>;
        
        var result = new List<IList<int>>();
        Array.Sort(nums);
        try
        {
            for(int i=0; i<nums.Length-2; i++)
            {
                if(i == 0 || (i > 0 && nums[i] != nums[i-1]))
                {
                    int startIndex = i+1;
                    int endIndex  = nums.Length - 1;
                    int expectedSum = -nums[i];

                    while(startIndex < endIndex)
                    {
                        if(nums[startIndex] + nums[endIndex] == expectedSum)
                        {
                            result.Add(new int[]{nums[i], nums[startIndex], nums[endIndex] });

                            while(startIndex < endIndex && nums[startIndex] == nums[startIndex+1])
                                startIndex++;
                            while(startIndex < endIndex && nums[endIndex] == nums[endIndex-1])
                                endIndex--;

                            startIndex++;
                            endIndex--;
                        }
                        else if (nums[startIndex] + nums[endIndex] < expectedSum)
                        {
                            startIndex++;
                        }
                        else
                            endIndex--;

                    }
                }
            }

        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
        }

        return result as IList<IList<int>>;
    }
}