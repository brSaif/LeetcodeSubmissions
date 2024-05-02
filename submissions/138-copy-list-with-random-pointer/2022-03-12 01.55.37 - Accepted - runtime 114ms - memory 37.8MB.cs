/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if (head == null)
                return null;

            var root = new Node(head.val);

            var oldNodes = new List<Node>
            {
                head
            };
            var newNodes = new List<Node>
            {
                root
            };

            Node tmp = head;
            Node tmpRoot = root;

            // Add all nodes to lists
            // and assign Node.next
            while (tmp.next != null)
            {
                tmpRoot.next = new Node(tmp.next.val);
                oldNodes.Add(tmp.next);
                newNodes.Add(tmpRoot.next);

                tmp = tmp.next;
                tmpRoot = tmpRoot.next;
            }

            // Assign Node.random
            for (int i = 0; i < oldNodes.Count; i++)
            {
                tmp = oldNodes[i];
                if (tmp.random != null)
                {
                    int randIndex = oldNodes.FindIndex(n => n == tmp.random);

                    newNodes[i].random = newNodes[randIndex];
                }
            }


            return root;
    }
}