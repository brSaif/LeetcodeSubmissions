/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null) return null;

        var oldAndNewNode = new Dictionary<Node, Node>();
        var isVisited = new HashSet<Node>();

        var queue = new Queue<Node>();
        queue.Enqueue(node);

        while (queue.Any()) {
            var size = queue.Count;
            for (int s = 0; s < size; s++) {
                var cur = queue.Dequeue();
                
                if (isVisited.Contains(cur)) continue;
                isVisited.Add(cur);
                if (!oldAndNewNode.ContainsKey(cur)) {
                    oldAndNewNode[cur] = new Node(cur.val, new List<Node>()); ;
                }
                var curNew = oldAndNewNode[cur];
                foreach (var next in cur.neighbors) {
                    if (!oldAndNewNode.ContainsKey(next)) {
                        oldAndNewNode[next] = new Node(next.val, new List<Node>());
                    }
                    var nextNew = oldAndNewNode[next];
                    curNew.neighbors.Add(nextNew);
                    queue.Enqueue(next);
                }
            }
        }
        return oldAndNewNode[node];
    }
}