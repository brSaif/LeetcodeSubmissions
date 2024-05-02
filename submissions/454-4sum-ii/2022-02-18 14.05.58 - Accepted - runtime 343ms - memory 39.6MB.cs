public class Solution {
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) {
        
        Dictionary<int,int> dic = new ();
        int len = nums1.Length, res = 0;
        
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len; j++){
                
                var sum = nums1[i] + nums2[j];
                if (dic.ContainsKey(sum)) dic[sum]++;
                else dic.Add(sum, 1);
            }
        }
        
        for (int p = 0; p < len; p++){
            for (int q = 0; q < len; q++){
                var sum = nums3[p] + nums4[q];
                if (dic.ContainsKey(-sum))   res += dic[-sum];
            }
        }
        
        return res;
    }
}