using BinaryTree.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        //Test Arrays sorted
        int[] oddArray = { 4, 9, 24, 27, 30, 35, 39, 46, 47, 51, 64, 68, 75, 82, 90 };
        int[] evenArray = { 1, 2, 3, 5, 6, 70, 80, 90, 100, 120 };


        int[] insertArray = { 81, 69, 4, 110, 74 };
        //Test Arrays unsorted
        int[] concatenatedArray = evenArray;

        
        
        Array.Sort(concatenatedArray);
        Node concatBST = BinTree.Create(concatenatedArray);

        Node oddBST = BinTree.Create(oddArray);
        Node evenBST = BinTree.Create(evenArray);

        Node? max_left_node = BinTree.GetMaxLeft(oddBST);

        //Console.WriteLine(BinTree.Search(oddBST, 28));
        //Console.WriteLine(BinTree.Search(evenBST, 6));
        //Console.WriteLine(BinTree.Search(evenBST, 11));
        //BinTree.Insert(oddBST, 28);
        foreach (int i in insertArray)
        {
            oddBST.Insert(i);
            oddBST.Search(i);
            evenBST.Insert(i);
            evenBST.Search(i);
        }
        Console.ReadKey();
    }
}