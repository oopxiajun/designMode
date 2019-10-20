using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_组合模式.Example_1
{
    public class CompositePatternDemo
    {
        public static void test()
        {
            TreeNode root = new TreeNode("根节点");

            TreeNode two_level1 = new TreeNode("二级节点---1");
            TreeNode two_level2 = new TreeNode("二级节点---2");

            TreeNode three_level1 = new TreeNode("三级节点---1");
            TreeNode three_level2 = new TreeNode("三级节点---2");
            TreeNode three_level3 = new TreeNode("三级节点---3");

            two_level1.AddChildNode(three_level1);
            two_level1.AddChildNode(three_level2);
            two_level1.AddChildNode(three_level3);

            root.AddChildNode(two_level1);
            root.AddChildNode(two_level2);

            ShowTree(root,"");
        }

        private static void ShowTree(TreeNode treeNode,string line) {
            Console.WriteLine(line + treeNode.NodeName);
            if (treeNode.Children.Count > 0) {
                foreach (var item in treeNode.Children)
                {
                    ShowTree(item, "____"+line);
                }
            }
        }
    }
}
