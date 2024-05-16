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
    public bool EvaluateTree(TreeNode root) {
        
        if (root == null) {
            return false;
        }
        if (root.val == 0) {
            return false;
        }
        if (root.val == 1) {
            return true;
        }
        bool left = EvaluateTree(root.left);
        bool right = EvaluateTree(root.right);
        return root.val == 2 ? left | right : left & right;
    }
}