public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var arr1 = list1.ToArray();
        var arr2 = list2.ToArray();

    if(arr1.Length == 2 && arr2.Length == 2)
    {
        return (Math.Max(arr1[0], arr2[0]) + Math.Min(arr1[1], arr2[1]))/2;
    }
    int mid1 = arr1.Length/2;
    int mid2 = arr2.Length/2;
    
    if(arr1[mid1] < arr2[mid2])
    {
        return GetMedian(arr1.Skip(mid1), arr2.Take(mid2));
    }
    else if (arr1[mid1] > arr2[mid2])
    {
        return GetMedian(arr1.Take(mid1), arr2.Skip(mid2));
    }
    else 
    {
        return arr1[mid1];
    }
    }
}