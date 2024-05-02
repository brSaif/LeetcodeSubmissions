public class Solution {
   public int ShortestPathLength(int[][] graph) {
        if (graph.Length == 1) {
            return 0;
        }
        
        int n = graph.Length;
        int endingMask = (1 << n) - 1;
        var seen = new bool[n,endingMask];
        var ourQueue = new List<(int, int)>();
        
        for (int i = 0; i < n; i++) {
            ourQueue.Add((i, 1 << i));
            seen[i, 1 << i] = true;
        }
        
        int steps = 0;
        while (ourQueue.Count > 0) {
            var nextQueue = new List<(int, int)>();
            for (int i = 0; i < ourQueue.Count; i++) {
                (int node, int mask) = ourQueue[i];
                foreach (int neighbor in graph[node]) {
                    int nextMask = mask | (1 << neighbor);
                    if (nextMask == endingMask) {
                        return 1 + steps;
                    }
                    
                    if (!seen[neighbor,nextMask]) {
                        seen[neighbor,nextMask] = true;
                        nextQueue.Add((neighbor, nextMask));
                    }
                }
            }
            steps++;
            ourQueue = nextQueue;
        }
        
        return -1;
    }
}