using BinaryTree.Lib;
using BinaryTree.Lib.Builder;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = { 4, 9, 24, 27, 30, 35, 39, 46, 47, 51, 64, 68, 75, 82, 90 };
        //TODO: Implement Base cases so as also even trees are being built
        //TODO: Graphical output????
        Node<int>? OddBST = Node.CreateTreeFromOddSequence(arr);
        Console.ReadKey();
    }

    

   


}