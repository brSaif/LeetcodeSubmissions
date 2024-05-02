public class Solution {
    public int FindMin(int[] arr) {
        int low = 0;
        int high = arr.Length - 1;
        int min = Int32.MaxValue;

        while(low <= high){
            int mid = (low + high)/2;

            if(arr[low] <= arr[mid]){
                min= arr[low] < min ? arr[low]: min;
                low = mid + 1;
            }

            else if (arr[high] >= arr[mid]){
                min = arr[mid] < min ? arr[mid]: min;
                high = mid - 1;
            }
        }

        return min; 
    }
}