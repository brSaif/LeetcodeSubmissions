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
    
    private int res = 0;
    
    public int SumRootToLeaf(TreeNode root) {
        if (root is null) return 0;
        dfs(root,0);
        return res;
    }
    
    private void dfs (TreeNode head, int num){
        if (head is null) return;
        num = num << 1 | head.val;
        if (head.left is null && head.right is null) 
        {
            res += num;
            return;
        }
        dfs (head.left, num);
        dfs (head.right, num);
        return;
    }
}