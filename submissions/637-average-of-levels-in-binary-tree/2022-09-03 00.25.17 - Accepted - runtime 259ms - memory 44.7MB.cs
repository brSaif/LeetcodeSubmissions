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
    
    IList<int> levelCount;
    IList<long> levelSum;
    
    private void DFS(TreeNode root, int level) {
        if (root == null)
            return;
        
        if (levelCount.Count < level) {
            levelCount.Add(1);
            levelSum.Add(root.val);
        }
        else {
            levelCount[level - 1]++;
            levelSum[level - 1] += root.val;
        }
        
        DFS(root.left, level + 1);
        DFS(root.right, level + 1);
    }
    
    public IList<double> AverageOfLevels(TreeNode root) {
        IList<double> result = new List<double>();
        levelCount = new List<int>();
        levelSum = new List<long>();
        
        DFS(root, 1);
        
        for (int i = 0; i < levelCount.Count; i++)
            result.Add((double)(levelSum[i]) / (double)(levelCount[i]));
        
        return result;
    }
}