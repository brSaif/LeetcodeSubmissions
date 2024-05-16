public class Solution {
    public double MincostToHireWorkers(int[] quality, int[] wage, int k) {
          var sorted = wage
        .Zip(quality, (w, q) => (ratio: w / (double)q, quality: q))
        .OrderBy(item => item.ratio);

      double result = double.PositiveInfinity;
      double totalQuality = 0.0;

      PriorityQueue<double, double> agenda = new();

      foreach ((double ratio, double qual) in sorted) {
        totalQuality += qual;

        agenda.Enqueue(qual, -qual);

        if (agenda.Count < k)
          continue;
        else if (agenda.Count > k)
          totalQuality -= agenda.Dequeue();

        result = Math.Min(result, totalQuality * ratio);
      }

      return result;

    }
}