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

    public IList<int> GetAllElements(TreeNode root1, TreeNode root2) {
        var list = new List<int>();         
        traverseInOrder(root1, list);
        
        var list2 = new List<int>(); 
        traverseInOrder(root2, list2);
        
        list.AddRange(list2);
        list.Sort(); 
        
        return list; 
    }
    
    private void traverseInOrder(TreeNode root1, IList<int> list)
    {
        if(root1 == null)
            return; 
        
        traverseInOrder(root1.left, list); 
        
        list.Add(root1.val);
        
        traverseInOrder(root1.right, list);         
    }
}