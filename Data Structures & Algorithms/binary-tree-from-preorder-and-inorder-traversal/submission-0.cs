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
    int pre_idx = 0;
    Dictionary<int,int> indices = new Dictionary<int,int>();
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        for(int i = 0 ;i<inorder.Length;i++) indices[inorder[i]] = i;
        return Dfs(preorder,0,inorder.Length-1);
    }
    public TreeNode Dfs(int[] preorder, int l, int r){
        if(l>r) return null;
        int root_val = preorder[pre_idx++];
        TreeNode node = new TreeNode(root_val);
        int mid = indices[root_val];
        node.left = Dfs(preorder,l,mid-1);
        node.right = Dfs(preorder,mid+1,r);
        return node;
    }
}
