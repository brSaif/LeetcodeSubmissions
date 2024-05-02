public class Solution {
    public int LastStoneWeight(int[] stones) {
        if (stones == null || stones.Length == 0) return 0;
        
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
        
        foreach (int stone in stones)
        {
            pq.Enqueue(stone, stone);
        }
        
        while (pq.Count > 1)
        {
            var stone = pq.Dequeue();
            stone -= pq.Dequeue();
            
            if (stone > 0)
            {
                pq.Enqueue(stone, stone);
            }
        }
        
        return pq.Count == 0 ? 0 : pq.Dequeue();
    }
}