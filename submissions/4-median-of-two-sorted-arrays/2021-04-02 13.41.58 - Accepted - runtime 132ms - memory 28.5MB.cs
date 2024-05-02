
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            var len1 = nums1.Length;
            var len2 = nums2.Length;
            var mid = (len1 + len2)/2;
            if ((len1 + len2)%2 == 0)
            {
                var left = FindMedianSortedArraysHelper2(nums1, nums2, mid);
                var right = FindMedianSortedArraysHelper2(nums1, nums2, mid + 1);
                return (left + right)/2;
            }
            else
            {
                return FindMedianSortedArraysHelper2(nums1, nums2, mid + 1);
            }
    }
    
     private double FindMedianSortedArraysHelper2(int[] nums1, int[] nums2, int tofind)
        {
            var count1 = nums1.Length;
            var count2 = nums2.Length;

            if (count1 > count2) return FindMedianSortedArraysHelper2(nums2, nums1, tofind);
            if (count1 == 0) return nums2[tofind - 1];
            if (tofind == 1) return Math.Min(nums1[0], nums2[0]);

            var mid1 = Math.Min(count1, tofind / 2);
            var mid2 = tofind - mid1;

            if (nums1[mid1 - 1] <= nums2[mid2 - 1])
            {
                return FindMedianSortedArraysHelper2(nums1.Skip(mid1).ToArray(), nums2, tofind - mid1);
            }
            else
            {
                return FindMedianSortedArraysHelper2(nums1, nums2.Skip(mid2).ToArray(), tofind - mid2);
            }
        }
}