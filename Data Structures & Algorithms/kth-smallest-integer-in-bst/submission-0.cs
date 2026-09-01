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
    public int KthSmallest(TreeNode root, int k) {
        List<int> res = new List<int>();
        dfs(root, res);
        return res[k-1];
    }
    public void dfs(TreeNode node, List<int> arr){
        if(node==null) return;
        dfs(node.left,arr);
        arr.Add(node.val);
        dfs(node.right,arr);
    }
}
