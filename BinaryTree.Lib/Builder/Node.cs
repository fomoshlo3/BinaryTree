using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree.Lib.Builder
{
    /// <summary>
    /// Recursive Methods for building a Binary Tree
    /// </summary>
    public partial class Node
    {
        public static Node<int>? CreateTreeFromOddSequence(int[] array)
        {
            Node<int>? leaf = null;
            if (array != null)
            {
                var index_of_median = GetMedian(array);
                Node<int> n = new(array[index_of_median]);

                while (index_of_median >= 1)
                {
                    n.LeftNode = CreateTreeFromOddSequence(array[..index_of_median]);
                    n.RightNode = CreateTreeFromOddSequence(array[^index_of_median..]);
                    return n;
                }
                leaf = new(array[0]);
            }
            return leaf;
        }

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
        /// Calculates  median
        /// </summary>
        /// <param name="size"></param>
        /// <returns>median if size is greater 1, otherwise 0</returns>
        private static int GetMedian(int size)
        {
            if (size > 1)
                return (int)(size / 2d);
            return 0;
        }
    }
}
