using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeValidation
{
    internal class EnrichedTreeNode : TreeNode
    {
        private int _min;
        private int _max;

        public int Min => _min;
        public int Max => _max;

        public EnrichedTreeNode(TreeNode node, int min, int max)
            : base(node.Data, node.Left, node.Right)
        {
            _min = min;
            _max = max;
        }

        public bool IsValid() =>
            Data > _min && Data < _max; 
    }
}
