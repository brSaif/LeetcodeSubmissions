public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
       int prd = 1;
       int zeroes = 0;
       var res = new int[nums.Length];

       foreach(var n in nums) {
           if (n == 0)
            { 
                zeroes++;
                if(zeroes > 1)
                {
                    Array.Fill(res, 0);
                    return res;
                }
                continue;
            }
           
            prd *= n;
       }

       for(int i = 0; i < nums.Length; i++){
           if (zeroes == 1 && nums[i] != 0)
                res[i] = 0;
            else if(nums[i] == 0)
                res[i] = prd;
            else 
                res[i] = prd/nums[i];
       }

       return res;
    }
}