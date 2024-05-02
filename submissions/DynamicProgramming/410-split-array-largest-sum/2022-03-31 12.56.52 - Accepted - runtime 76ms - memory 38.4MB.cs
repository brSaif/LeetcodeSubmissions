public class Solution {
    public int SplitArray(int[] nums, int m) {
        int l = nums.Max();
        int r = nums.Sum();
        int res = r;
        while (l <= r){
            int mid = l + (r - l)/2;
            if (CanSplit(mid, nums, m)){
                res = mid;
                r = mid - 1;
            }else
                l = mid + 1;
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
            }
        }
        
        return subarray + 1 <= maxSplit;
    }
}