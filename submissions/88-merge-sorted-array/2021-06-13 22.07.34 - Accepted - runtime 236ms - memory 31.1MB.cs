public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int maxLen = n + m;
        
       while(n > 0 && m > 0){
            if(nums1[m -1] < nums2[n -1]){
                nums1[maxLen -1] = nums2[n -1];
                n--;
            }else {
                nums1[maxLen -1] = nums1[m -1];
                m--;
            }
            maxLen--;                    
        }
            
            while(n > 0){
                nums1[maxLen -1] = nums2[n - 1];
                n--;
                maxLen -- ;
                    
            }
        
    }
}