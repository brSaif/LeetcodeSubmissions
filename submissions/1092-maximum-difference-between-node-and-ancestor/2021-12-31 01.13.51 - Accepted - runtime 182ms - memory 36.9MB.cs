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
    public int MaxAncestorDiff(TreeNode root) {
        if (root is null) return 0;
        
        return dfs(root, root.val, root.val);
    }
    
    private int dfs (TreeNode root,int currMax, int currMin){
        if(root is null) return currMax - currMin;
        currMax = Math.Max(currMax, root.val);
        currMin = Math.Min(currMin, root.val);
        int left = dfs(root.left,currMax,currMin);
        int right = dfs(root.right,currMax,currMin);
        return Math.Max(left,right);
    }
}