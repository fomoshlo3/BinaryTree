using BinaryTree.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 4, 9, 24, 27, 30, 35, 39, 46, 47, 51, 64, 68, 75, 82, 90 };
        //TODO: Implement Base cases so as also even trees are being built
        //TODO: Graphical output????
        Node<int>? OddBST = CreateTreeFromOddSequence(arr);
        Console.ReadKey();
    }

    private static Node<int>? CreateTreeFromOddSequence(int[] array)
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
    public static int GetMedian<T>(IList<T> list)
    {
        return GetMedian(list.Count);
    }

    /// <summary>
    /// Calculates index of median in a sequence
    /// </summary>
    /// <param name="arr"></param>
    /// <returns><para>int</para></returns>
    public static int GetMedian(int[] arr)
    {
        return GetMedian(arr.Length);
    }
    /// <summary>
    /// Calculates integer median
    /// </summary>
    /// <param name="size"></param>
    /// <returns>median floored as integer if size is greater 1, otherwise 0</returns>
    public static int GetMedian(int size)
    {
        if (size > 1)
            return (int)Math.Floor(size / 2d);
        return 0;
    }


}