public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        List<int> indices = (from p in flowerbed.Select((x, i) 
                                                        => (value: x, index: i))
                             where p.value == 1
                             select p.index
                            ).Prepend(-2).Append(flowerbed.Length + 1).ToList();
        return indices.Zip(indices.Skip(1)).
            Select(p => (p.Item2 - p.Item1 - 2) / 2).Sum() >= n;
    }
}