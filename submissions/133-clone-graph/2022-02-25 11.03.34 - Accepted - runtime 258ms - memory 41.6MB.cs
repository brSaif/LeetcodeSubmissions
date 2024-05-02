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
    public Node CloneGraph(Node node) 
        => node is null ? null : Clone(node, new Dictionary<Node, Node>());
    
    private Node Clone(Node node, IDictionary<Node, Node> dic){
        if (dic.TryGetValue(node, out var existing)) return existing;
        
        Node clone = dic[node] = new Node(node.val);
        clone.neighbors = node.neighbors.Select(x => Clone(x, dic)).ToList();
        return clone;
    }
}