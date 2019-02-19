using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 二叉树最大深度算法
{  public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }

        public int MaxDepth(TreeNode root)
        {
            //根节点为空         返回0
            if (root == null)
            {
                return 0; 
            }
            else
            {
                //计算 左节点 的值
                int lCount = MaxDepth(root.left); 
                //计算 右节点的值
                int rCount = MaxDepth(root.right);
                //返回 最大深度 ，再加上 root层
                return Math.Max(lCount, rCount) + 1;
            }
        }
        public int MaxDepth2(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            //存储所有的 节点 
            Queue<KeyValuePair<TreeNode, int>> all = new Queue<KeyValuePair<TreeNode, int>>();// int:depth
            //把Root加入
            all.Enqueue(new KeyValuePair<TreeNode, int>(root, 1));

            int depth = 1;

            //还有节点
            while (all.Count!=0)
            {

                var cur = all.Dequeue();
                TreeNode cuNode = cur.Key;
                int curDepth = cur.Value;

                if (cuNode!=null)
                {
                    depth = Math.Max(curDepth, depth);
                    all.Enqueue(new KeyValuePair<TreeNode, int>(cuNode.left, curDepth + 1));//+1 表示 取下一次的
                    all.Enqueue(new KeyValuePair<TreeNode, int>(cuNode.right, curDepth + 1));
                }
                
            }

            return depth;

        }
    }
}
