using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Lib
{
    /// <summary>
    /// Builder Class for different kinds of Trees
    /// </summary>
    public class TreeBuilder
    {
        private int[]? _data;

        public TreeBuilder(int[] arr) { }

        public Node CreateOrdered(int id)
        {
            Node node = new Node(id);
            return node;
        }
    }
}
