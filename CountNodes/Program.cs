// Given the root of a complete binary tree, return the number of the nodes in the tree.
//
//     According to Wikipedia, every level, except possibly the last, is completely filled in a complete binary tree, and all nodes in the last level are as far left as possible. It can have between 1 and 2h nodes inclusive at the last level h.
//
//     Design an algorithm that runs in less than O(n) time complexity.
//
//  
//
//     Example 1:
//
//
// Input: root = [1,2,3,4,5,6]
// Output: 6
// Example 2:
//
// Input: root = []
// Output: 0
// Example 3:
//
// Input: root = [1]
// Output: 1
//  
//
// Constraints:
//
// The number of nodes in the tree is in the range [0, 5 * 104].
// 0 <= Node.val <= 5 * 104
// The tree is guaranteed to be complete.


 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
     }
 }
 
public class Solution {
    public int CountNodes(TreeNode root) {
        if(root == null) return 0;
        return 1 + CountNodes(root.left) + CountNodes(root.right);
        
        
    }
}



class Program {
    static void Main(string[] args) {
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);
        root.right.left = new TreeNode(6);
        Solution solution = new Solution();
        int result = solution.CountNodes(root);
        Console.WriteLine(result); // Output: 6
    }
}