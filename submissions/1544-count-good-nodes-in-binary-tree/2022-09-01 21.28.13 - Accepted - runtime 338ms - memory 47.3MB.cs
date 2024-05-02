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
    public int GoodNodes(TreeNode root) { 
        if(root == null){ return 0; }
        int count = 1;
        
        count += dfs(root.left, root.val);
        count += dfs(root.right, root.val);
        return count;
    }
    
    public int dfs(TreeNode root, int currentMax){
        
        int amount = 0; 
        if(root == null){ return 0; }
        if(root.val >= currentMax){
            amount++; 
            currentMax = root.val;
        }
        
        amount += dfs(root.left, currentMax);
        amount += dfs(root.right, currentMax);
        return amount; 
    }
}