using BinaryTree.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        //Test Arrays sorted
        int[] oddArray = { 4, 9, 24, 27, 30, 35, 39, 46, 47, 51, 64, 68, 75, 82, 90 };
        int[] evenArray = { 1, 2, 3, 5, 6, 70, 80, 90, 100, 120 };


        int[] insertArray = { 81, 69, 4, 110, 74 };

        #region Rekursives erstellen eines Binären Suchbaumes aus einem sortierten Array.
        Node oddBST = BinTree.Create(oddArray);
        Node evenBST = BinTree.Create(evenArray);
        #endregion
        #region Ausgabe größter und kleinster Wert im Baum
        Node? max_left_node = BinTree.GetMaxLeft(oddBST);
        Node? max_right_node = BinTree.GetMaxRight(oddBST);

        #endregion
        #region Ausgabe aufsteigend / absteigend
        int?[] unboxedAscendingBeforeInsert = BinTree.Unbox(oddBST, default);
        int?[] unboxedDescendingBeforeInsert = BinTree.Unbox(oddBST, 1);

        Console.WriteLine($"Ascending: {nameof(oddBST)}");
        foreach (int? i in unboxedAscendingBeforeInsert)Console.Write($"{i} ,");
        Console.WriteLine();

        
        Console.WriteLine($"Descending: {nameof(oddBST)} ");
        foreach (int? i in unboxedDescendingBeforeInsert) Console.Write($"{i} ,");
        Console.WriteLine();
        #endregion
        #region Insert und abermals Ausgabe
        foreach (int i in insertArray) { oddBST.Insert(i); }

        int?[] unboxedAscendingAfterInsert = BinTree.Unbox(oddBST, default);
        int?[] unboxedDescendingAfterInsert = BinTree.Unbox(oddBST, 1);
        
        Console.WriteLine($"Ascending: {nameof(oddBST)}");
        foreach (int? i in unboxedAscendingAfterInsert)
        {
            Console.Write($"{i} ,");
        }
        Console.WriteLine();

        Console.WriteLine($"Descending: {nameof(oddBST)} ");
        foreach (int? i in unboxedDescendingAfterInsert)
        {
            Console.Write($"{i} ,");
        }
        Console.WriteLine();
        #endregion

        Console.ReadKey();
    }
}