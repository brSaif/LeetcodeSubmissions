public class Solution {
   public int SplitArray(int[] nums, int m) {
        int l = nums.Max();
        int r = nums.Sum();
        return BinarySearch(l, r, nums, m);
    }
    
    private int BinarySearch(int max, int sum, int[] nums, int maxSplit){
        int res = sum;
        while (max <= sum){
            int mid = max + (sum - max)/2;
            if (CanSplit(mid, nums, maxSplit)){
                res = mid;
                sum = mid - 1;
            }else
                max = mid + 1;
        }
        return res;
    }
    
    private bool CanSplit(int largest,int[] nums, int maxSplit){
        int subarray = 0;
        int currSum = 0;
        
        foreach (var n in nums){
            currSum += n;
            if (currSum > largest){
                subarray +=1;
                currSum = n;
                if (subarray + 1 > maxSplit)
                    return false;
            }
        }
        
        return true;
    }
}