public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        double result = 0.0;
        int[] numf = new int[nums1.Length + nums2.Length];
        int left = 0;
        int right = 0;
        int runner = 0;
        bool flag = true;
        bool filler = true;
        if(nums1.Length == 0){
            numf = nums2;
            flag = false;
        } else if(nums2.Length == 0){
            numf = nums1;
            flag = false;
        }
        while(flag){
            if(nums1[left] < nums2[right]){
                numf[runner] = nums1[left];
                left++;
                runner++;
            } else {
                numf[runner] = nums2[right];
                right++;
                runner++;
            }
            if(left >= nums1.Length){
                flag = false;
                while(filler){
                    numf[runner]= nums2[right];
                    right++;
                    runner++;
                    if(right >= nums2.Length){
                        filler = false;
                    }
                }
            }
            if(right >= nums2.Length){
                flag = false;
                while(filler){
                    numf[runner]= nums1[left];
                    left++;
                    runner++;
                    if(left >= nums1.Length){
                        filler = false;
                    }
                }
            }
        }
        if(numf.Length % 2 != 0){
            result = numf[numf.Length / 2];
        } else {
            result = (numf[numf.Length / 2] + numf[(numf.Length / 2) - 1]) / 2.0;
        }
        return result;
    }
}