public class Solution {
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) {
        
        Dictionary<int, int> seen = new();
        int len = nums1.Length, res = 0;
        
        for (int i = 0; i < len; i++){
            for (int j = 0; j < len; j++){
                int sum = nums1[i] + nums2[j];
                if (seen.ContainsKey(sum)) seen[sum]++;
                else seen.Add(sum, 1);
            }
        }
        
        for (int i = 0; i < len; i++){
            for (int j = 0; j < len; j++){
                int sum = nums3[i] + nums4[j];
                if (seen.ContainsKey(-sum)) res += seen[-sum];
            }
        }
        
        return res;
    }
}