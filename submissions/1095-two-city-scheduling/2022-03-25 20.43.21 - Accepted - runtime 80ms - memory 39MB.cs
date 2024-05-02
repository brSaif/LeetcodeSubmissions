public class Solution {
    public int TwoCitySchedCost(int[][] costs) =>
            costs.OrderBy(cost => cost[0] - cost[1])
                .Select((cost, i) => i < costs.Length / 2 ?  cost[0] : cost[1])
                .Sum();
        
    
}