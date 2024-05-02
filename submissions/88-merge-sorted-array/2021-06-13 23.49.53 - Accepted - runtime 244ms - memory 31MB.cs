public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int len = m+n -1;
        while(n > 0 && m > 0){
            if(nums1[m -1] < nums2[n - 1]){
                nums1[len] = nums2[n - 1];
                n--;
            }else{
                nums1[len] = nums1[m - 1];
                m--;
            }
            len--;
        } 
        
        while(n > 0){
            nums1[len] = nums2[n - 1];
            n--;
            len --;
        }
    }
}