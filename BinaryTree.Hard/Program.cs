using BinaryTree.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 4, 9, 24, 27, 30, 35, 39, 46, 47, 51, 64, 68, 75, 82, 90 };


        //Node<int> root = Create(arr);
        Node<int> OddBST = CreateOdd(arr);
        //Node<int> EvenBST = Create(arr2);
        Console.ReadKey();
    }


    private static Node<int> CreateOdd(int[] array)
    {
        if (array != null)
        {
            var index_of_median = GetMedian(array);
            var lArr = array.Take(index_of_median).ToArray(); 
            var rArr = array.Skip(index_of_median + 1).ToArray(); //C#10 referenc auf Array arr[^7] = 
            Node<int> n = new(array[index_of_median]);
            
            while (index_of_median >= 1)
            {
                if (lArr != null) n.LeftNode = CreateOdd(lArr);
                if (rArr != null) n.RightNode = CreateOdd(rArr);
                return n;
            }
        }
        Node<int> leaf = new(arr[0]); 
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
            return Convert.ToInt32(Math.Floor(size / 2d));
        return 0;
    }


}