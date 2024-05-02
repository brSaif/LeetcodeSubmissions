public class Solution {
    public IList<int> SequentialDigits(int low, int high) =>
        (from numberOfDigits in Enumerable.Range((int)Math.Log10(low) + 1, (int)Math.Log10(high) - (int)Math.Log10(low) + 1)
         from startingDigit in Enumerable.Range(1, 10 - numberOfDigits)
         select Enumerable.Range(startingDigit, numberOfDigits)
            .Aggregate((p, n) => p * 10 + n) into number
         where low <= number && number <= high
         select number).ToArray();
}