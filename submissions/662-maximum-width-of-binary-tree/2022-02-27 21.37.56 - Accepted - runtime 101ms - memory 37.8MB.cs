/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int WidthOfBinaryTree(TreeNode root) {
         var queue = new Queue<(int, TreeNode)>();
        queue.Enqueue((0, root));
        int max = 0;
        while(queue.Any()) {
            var count = queue.Count;
            var (p, n) = queue.Peek();
            int left = p, right = p;
            while (count-- > 0) {
                (p, n) = queue.Dequeue();
                if (p < left) left = p;
                if (p > right) right = p;
                if (n.left != null) queue.Enqueue((2 * p + 1, n.left));
                if (n.right != null) queue.Enqueue((2 * p + 2, n.right));
            }
            Console.WriteLine();
            max = Math.Max(max, right - left + 1);
        }
        
        return max;
    }
}