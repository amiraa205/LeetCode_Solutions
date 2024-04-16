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
    public TreeNode AddOneRow(TreeNode root, int val, int depth) {
         switch (depth)
        {
            case 1:
                return new TreeNode(val, root, null);
            case 2:
            {
                root.left = new TreeNode(val, root.left, null);
                root.right = new TreeNode(val, null, root.right);
                break;
            }
            default:
            {
                if (root.left != null)
                    AddOneRow(root.left, val, depth - 1);
                if (root.right != null)
                    AddOneRow(root.right, val, depth - 1);
                break;
            }
        }
        return root;
    }
}