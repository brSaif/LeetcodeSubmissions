public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        int minLen = Math.Min(nums1.Length,nums2.Length);
        int maxLen = Math.Max(nums1.Length,nums2.Length);
        int[] smlArr = new int[minLen];
        int[] bigArr = new int[maxLen];
        int[] result = new int[minLen];
        
        if(nums1.Length > nums2.Length){
            smlArr  = nums2;
            bigArr = nums1;
        }else{
            smlArr  = nums1;
            bigArr = nums2;
        }
        
        if(minLen == 0) return result;
        
        int left = 0, right = 0,  count = 0;
        Array.Sort(smlArr);
        Array.Sort(bigArr);
        while(right < maxLen){
            while(smlArr[left] != bigArr[right] &&
                 right < maxLen ){
                right++;
            }
            
            if(smlArr[left] == bigArr[right]
              && left < minLen){
                result[count] = smlArr[left];
                count ++;
                left ++;
                right ++;
            }
        } 
        
        return result;
    }
}