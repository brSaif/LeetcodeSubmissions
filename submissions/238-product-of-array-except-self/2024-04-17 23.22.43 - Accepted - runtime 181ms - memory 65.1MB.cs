public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var zerosCount = 0;
        var allNumbrsProduct = 1;

        foreach(var n in nums){
            if (n == 0) 
                zerosCount++;
            else
                allNumbrsProduct *= n;

            if(zerosCount >= 2)
            {
                Array.Fill(nums, 0);

                return nums;
            }
        }

        if (zerosCount == 1 )
        {
            for(int i = 0; i < nums.Length; i++){
                if (nums[i] != 0)
                    nums[i] = 0;
                else
                    nums[i] = allNumbrsProduct;
            }
        }
        else
        {
            for(int i = 0; i < nums.Length; i++){
                nums[i] = allNumbrsProduct / nums[i];
            }
        }

        return nums;
    }
}