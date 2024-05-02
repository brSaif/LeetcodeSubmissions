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
    public int MaxDepth(TreeNode root) {
        
        if (root is null) return 0;
        
        int depth = 0;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while(queue.Count != 0)
        {
            int size = queue.Count;
            
            for(int i = 0; i < size; i++){
                
                var node = queue.Dequeue();
                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);
                
            }
            
            depth++;

        }
        return depth;
    }
}