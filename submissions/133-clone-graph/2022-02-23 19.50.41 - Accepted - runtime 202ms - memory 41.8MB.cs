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
        return node != null ? Clone(node, new Dictionary<Node, Node>()) : null;

        static Node Clone(Node node, IDictionary<Node, Node> cloneBySource) {
            if (cloneBySource.TryGetValue(node, out var existing)) return existing;

            var clone = cloneBySource[node] = new Node(node.val);
            clone.neighbors = node.neighbors.Select(n => Clone(n, cloneBySource)).ToList();
            return clone;
        }
    }
}