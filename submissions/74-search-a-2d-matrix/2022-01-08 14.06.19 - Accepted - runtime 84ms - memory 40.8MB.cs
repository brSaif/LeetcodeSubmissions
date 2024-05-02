public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        try
        {
            var row = matrix.First(row => row[row.Length - 1] >= target).ToArray();
            var index = Array.BinarySearch(row, target);
            return index >= 0;
        }
        catch (InvalidOperationException e)
        {
            return false;
        }   
    }
}