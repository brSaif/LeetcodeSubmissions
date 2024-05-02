public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int maxLen = m + n -1;
        m -= 1;
        n -= 1;
        while(m > 0 && n > 0){
            if(nums1[m] > nums2[n]){
                nums1[maxLen--] =  nums1[m--];
            }else{
                nums1[maxLen--] =  nums2[n--];
            }
            
        }
        
        while(n >= 0){
            nums1[maxLen--] = nums2[n--];
        }
    }
}