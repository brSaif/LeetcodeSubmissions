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
    private TreeNode res;
    public TreeNode SearchBST(TreeNode root, int val) {
        if (root is null) return null;
        else if (root.val == val) return root;
        else if (root.val < val) res = SearchBST(root.right, val);
        else res = SearchBST(root.left, val);
        return res;
    }
}