using BinaryTree.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 4, 9, 24, 27, 30, 35, 39, 46, 47, 51, 64, 68, 75, 82, 90 };

        Node<int> root = Create(arr);

        Console.ReadKey();
    }

    private static Node<int> Create(int[] arr)
    {
        if(arr != null)
        {
        var index_of_median = GetMedian(arr);
        var lArr = arr.Take(index_of_median).ToArray();
        var rArr = arr.Skip(index_of_median + 1).ToArray();
            while(index_of_median > 1)
            {
            Node<int> n = new(arr[index_of_median]);
            if(lArr != null)
                return n.LeftNode = Create(lArr);
            if(rArr != null)
                return n.RightNode = Create(rArr);

            }
        }
        return null;
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
    /// <returns></returns>
    public static int GetMedian(int size)
    {
        return Convert.ToInt32(Math.Floor(size / 2d));
    }


}