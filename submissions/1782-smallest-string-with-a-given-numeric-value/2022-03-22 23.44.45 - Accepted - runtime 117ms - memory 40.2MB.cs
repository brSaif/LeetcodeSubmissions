public class Solution {
    public string GetSmallestString(int n, int k) {
        if(n < 1)
            throw new ArgumentException("Invalid Input");
        
        char[] arr = new char[n];
        Array.Fill(arr, 'a');
        k -= n;
        
        for(int j = n - 1; j >= 0 && k > 0; j--)
        {
            int supplement = Math.Min(25, k);
            k -= supplement;
            
            arr[j] = Convert.ToChar(arr[j] + supplement);
        }
        
        return new string(arr);
    }
}