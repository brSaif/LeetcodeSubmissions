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
      public int SumRootToLeaf(TreeNode root) {
        return Sum(root, 0);
    }
    
    int Sum(TreeNode node, int sum) {
        if(node.left == null && node.right == null) return sum << 1 | node.val;
        
        else if(node.left == null) return Sum(node.right, sum << 1 | node.val); 
        
        else if(node.right == null) return Sum(node.left, sum << 1 | node.val);
        
        return Sum(node.left, sum << 1 | node.val) + Sum(node.right, sum << 1 | node.val);
    }
}