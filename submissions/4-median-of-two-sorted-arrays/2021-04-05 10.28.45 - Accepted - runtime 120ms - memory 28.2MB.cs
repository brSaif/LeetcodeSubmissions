public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

             int size1 = nums1.Count();
        int size2 = nums2.Count();
        int i=0, j=0;
        var st = new Stack<int>();
        
        while(i + j <= (size1 + size2) / 2)
        {
            if (i == size1 && j < size2){
                st.Push(nums2[j]);
                j++;
            } else if (j == size2 && i < size1){
                st.Push(nums1[i]);
                i++;
            } else if(nums1[i] < nums2[j]){
                st.Push(nums1[i]);
                i++;
            } else if(nums1[i] >= nums2[j]){
                st.Push(nums2[j]);
                j++;
            }
        }
        
        
        if((size1 + size2) % 2 == 0)
        {
            return (st.Pop() + st.Pop()) / 2.0;
        } 
    
        return st.Pop();
    }

       
}