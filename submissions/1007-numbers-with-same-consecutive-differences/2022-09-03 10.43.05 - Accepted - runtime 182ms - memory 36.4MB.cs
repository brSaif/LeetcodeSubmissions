public class Solution {
        
    public int[] NumsSameConsecDiff(int n, int k) {
        
       HashSet<int> res = new( new[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9 } );

        for (int i = 1; i < n; i++)
        {
            foreach (int num in res.Where(x => x >= Math.Pow(10, i - 1)).ToArray())
            {
                int upper = num % 10 + k; //first candidate for the next digit
                int lower = num % 10 - k; //second candidate for the next digit

                if (upper <= 9) res.Add(num * 10 + upper);
                if (lower >= 0) res.Add(num * 10 + lower);
            }
        }

        return res.Where(x => x >= Math.Pow(10, n - 1)).ToArray();
    }
}