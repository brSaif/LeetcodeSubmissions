public class Solution {
    public double MincostToHireWorkers(int[] quality, int[] wage, int k) {
        var len = wage.Length;
        var result = Double.MaxValue;
        for (int i = 0; i < len; i++)
        {
            var ratio = (double) wage[i] / quality[i];
            var acceptedOffers = new List<double>();

            for (int j = 0; j < len; j++)
            {
                if (i == j)
                    continue;

                double proportionalWage = ratio * quality[j];

                if (proportionalWage < wage[j])
                    continue;

                acceptedOffers.Add(proportionalWage);

                //Console.WriteLine($"i : {i} - j : {j} - ratio {ratio} - proportionalWage {proportionalWage}");
            }

            if(acceptedOffers.Count < k - 1) 
                continue;

            var localCost = acceptedOffers.OrderBy(c => c).Take(k -1).Sum() + wage[i];

            result = Math.Min(result, localCost);
        }

        return result;
    }
}