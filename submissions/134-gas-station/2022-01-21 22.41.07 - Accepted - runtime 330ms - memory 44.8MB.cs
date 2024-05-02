public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost)=> gas
        .Zip(cost, (g, c) => g - c)
        .Select((diff, index) => (diff, index))
        .Aggregate((sum: 0, res: (min: Int32.MaxValue, index: 0)), 
                   (pos, cur) => (pos.sum + cur.diff, 
                                  pos.sum + cur.diff < pos.res.min ? (pos.sum + cur.diff, cur.index + 1) : pos.res),
                   pos => pos.sum < 0 ? -1 : pos.res.index % gas.Length);
}