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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        if (root is null) return new TreeNode(val);
        dfs (root, val);
        return root;
    }
    
    private void dfs (TreeNode head, int val){
        if (head.val < val && head.right != null) dfs(head.right, val);
        else if (head.val > val && head.left != null) dfs(head.left, val);
        else if (val < head.val && head.left is null)  {
            head.left = new TreeNode(val);
            return;
        }
        else {
            head.right = new TreeNode(val);
            return;
        }
        
    }
}