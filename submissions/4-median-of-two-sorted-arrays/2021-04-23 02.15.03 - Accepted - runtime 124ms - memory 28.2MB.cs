public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
        if(nums1.Length > nums2.Length)
        {
            return FindMedianSortedArrays(nums2, nums1);
        }
        
        int l1 = nums1.Length;
        int l2 = nums2.Length;
        
        int low = 0;
        int high = l1;
        
        while(low <= high)
        {
            int partitionX = (low + high) / 2;
            int partitionY = (l1 + l2 + 1)/ 2 - partitionX;
            
            // if partition is 0 it means nothing is there on left side, use -inf
            
            var maxLeftX = partitionX == 0 ? int.MinValue : nums1[partitionX - 1];
            var minRightX = partitionX == l1 ? int.MaxValue : nums1[partitionX];
            var maxLeftY = partitionY == 0 ? int.MinValue : nums2[partitionY - 1];
            var minRightY = partitionY == l2 ? int.MaxValue : nums2[partitionY];
            
            if (maxLeftX <= minRightY && maxLeftY <= minRightX)
            {
                // We partitioned on the correct place
                
                // get max of left elements of right elements 
                
                if ((l1 + l2) % 2 == 0)
                {
                    return (double)(Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY)) / 2;
                }
                else
                {
                    return (double)(Math.Max(maxLeftX, maxLeftY));
                }
            }
            else if (maxLeftX > minRightY)
            {
                // we are too far on right side for partitionX
                high = partitionX -1 ;
            }
            else
            {
                low = partitionX + 1;
            }
        }
        
        throw new Exception();
    }
}