public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var set = new Dictionary<int, int>();

        foreach(var n in nums)
        {
            if(set.ContainsKey(n))
                set[n]++;
            else
                set.Add(n, 1);
        }

        var priorityQueue = new PriorityQueue<int, int>();

        foreach(var kvp in set)
        {
            priorityQueue.Enqueue(kvp.Key, kvp.Value);

            if (priorityQueue.Count > k){
                priorityQueue.Dequeue();
            }
        }

        var res = new int[k];
    
        while (k > 0)
        {
            res[k - 1] = priorityQueue.Dequeue();
            k--;
        }

        return res;

    }
}