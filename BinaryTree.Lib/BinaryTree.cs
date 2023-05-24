using System.Linq;

namespace BinaryTree.Lib
{
    /// <summary>
    /// Recursive Methods for building a Binary Tree, we use the node class here
    /// </summary>
    public static class BinTree
    {
   /// <summary>
        /// Recursively builds a binary tree from a given array of int values
        /// </summary>
        /// <param name="values"></param>
        /// <returns>if array was sorted : RootNode of a Balanced BinaryTree
        /// if Array was unsorted : RootNode of a BinaryTree</returns>
        public static Node Create(int[] values)
        {
            int length = values.Length;
            Node? node = null;
            switch (length)
            {
                case 1: // Base Case
                    return node = new(values[0]);
                case 2:
                    int min = Math.Min(values[0], values[1]);
                    int max = Math.Max(values[0], values[1]);
                    node = new(max);
                    node.LeftChild = new(min);
                    return node;
                default: // Recursion
                    int median = GetMedian(length);
                        node = new(values[median]);
                        node.LeftChild = Create(values[..median]);
                        node.RightChild = Create(values[(median+1)..]); 
                    return node;
            }
        }

        #region Unbox
        /// <summary>
        /// recursively unboxes all nodes in a given tree
        /// by default: ascending
        /// with option set to one : descending
        /// 
        /// more options may come soon :)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static int?[] Unbox(Node root, int? options)
        {
            Stack<int?> values = new Stack<int?>();
            switch (options)
            {
                case 1: values = UnboxDescending(root, values); break;
                default: values = UnboxAscending(root, values);break;
            }
            return values.ToArray();
        }

        private static Stack<int?> UnboxDescending(Node node, Stack<int?> values)
        { 
            if(node.LeftChild != null) UnboxDescending(node.LeftChild, values);
            values.Push(node.Value);
            if(node.RightChild != null) UnboxDescending(node.RightChild, values);
            return values;
        }

        private static Stack<int?> UnboxAscending(Node node, Stack<int?> values)
        {
            if (node.RightChild != null) UnboxAscending(node.RightChild, values);
            values.Push(node.Value);
            if (node.LeftChild != null) UnboxAscending(node.LeftChild, values);
            return values;
        }
        #endregion

        /// <summary>
        /// returns node with smallest id value in tree 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static Node? GetMaxLeft(Node root)
        {
            while(root.LeftChild != null)
                return GetMaxLeft(root.LeftChild);
            return root;
        }

        /// <summary>
        /// returns node with biggest id value
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static Node? GetMaxRight(Node root)
        {
            while (root.RightChild != null)
                return GetMaxRight(root.RightChild);
            return root;
        }

        /// <summary>
        /// Searches a tree for a value, if non existent returns the value of last Node checked (which would also be the "nearest" to thus value by logic)
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Node Search(this Node node, int value)
        {
            if (value < node.Value && node.LeftChild != null) return Search(node.LeftChild, value);
            if (value > node.Value && node.RightChild != null) return Search(node.RightChild, value);
            return node;
        }

        /// <summary>
        /// Inserts new Node with given Value if not already existent at the Node checked last.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Node? Insert(this Node node,int value)
        {
            var lastNode = Search(node, value);
            if (lastNode.Value > value) return lastNode.LeftChild = new(value);
            if (lastNode.Value < value) return lastNode.RightChild = new(value);
            return null;
        }

        #region Not thought through
        /// <summary>
        /// TODO: Should be a optional Method or Task for self-balancing, thus maybe another name.
        /// </summary>
        /// <param name="rootNode"></param>
        public static void SortTree(Node rootNode)
        {
           //take the value of Node and Compare to left and right child 
        }

        private static void Swap(this Node n1, Node n2)
        {
            var temp = n1;
            n1 = n2;
            n2 = temp;
        }
        #endregion

        /// <summary>
        /// Calculates Median
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns>Index of Median in a Generic List<<typeparamref name="T"/>></returns>
        private static int GetMedian<T>(IList<T> list)
        {
            return GetMedian(list.Count);
        }
        /// <summary>
        /// Calculates index of median in a sequence
        /// </summary>
        /// <param name="arr"></param>
        /// <returns><para>int</para></returns>
        private static int GetMedian(int[] arr)
        {
            return GetMedian(arr.Length);
        }
        /// <summary>
        /// Calculates  median, conditioned so as you always build tree with bigger right branch.
        /// </summary>
        /// <param name="size"></param>
        /// <returns>median if size is greater 1, otherwise 0</returns>
        private static int GetMedian(int size)
        {
            if (size % 2 == 0) return size / 2 - 1;
            return size / 2;
        }
    }
}
