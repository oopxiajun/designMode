using System;
using System.Collections.Generic;
using System.Text;

namespace Composite_组合模式.Example_1
{
    public class TreeNode
    {
        public string NodeName { get; set; }

        public List<TreeNode> Children { get; set; }

        public TreeNode() { Children = new List<TreeNode>(); }

        public TreeNode(string nodeName) : this() => NodeName = nodeName;

        public void AddChildNode(TreeNode node)
        {
            Children.Add(node);
        }

        public void RemoveChildNode(TreeNode node)
        {
            Children.Remove(node);
        }
    }
}
