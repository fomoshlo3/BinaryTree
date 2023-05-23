using BinaryTree.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 4, 9, 24, 27, 30, 35, 39, 46, 47, 51, 64, 68, 75, 82, 90 };
        int[] arr2 = { 1, 2, 3, 4, 5, 6,7,8,9,10 };
        //TODO: Implement Base cases so as also even trees are being built
        //TODO: Graphical output????
        Node oddBST = BinTree.Create(arr);
        Node evenBST = BinTree.Create(arr2);

        Console.WriteLine(BinTree.Search(oddBST, 28));
        Console.WriteLine(BinTree.Search(evenBST, 6));
        Console.WriteLine(BinTree.Search(evenBST, 11));
        BinTree.Insert(oddBST, 28);


        Console.ReadKey(); 
    }
}