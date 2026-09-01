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
    public bool IsValidBST(TreeNode root) {
        return validBST(root, long.MinValue, long.MaxValue);
    }
    public bool validBST(TreeNode node,long left, long right){
        if(node == null) return true;
        if(!(node.val < right && node.val > left)) return false;

        return validBST(node.left,left,node.val) && validBST(node.right,node.val,right);
    }
}
