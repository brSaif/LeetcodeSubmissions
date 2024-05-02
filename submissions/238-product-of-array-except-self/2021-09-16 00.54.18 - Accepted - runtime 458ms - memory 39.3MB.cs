public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int temp = 1;
        int n = nums.Length;
        var arr2 = new int[n];
        
        Array.Fill(arr2,1);
        
        for(int i = 0; i < n; i++){
            arr2[i] = temp;
            temp *= nums[i]; 
        }
        temp = 1;
        for(int i = n-1; i >= 0; i--){
            arr2[i] *= temp;
            temp *= nums[i];
        }
        
        return arr2;
        
    }
}