namespace BinaryTree.Lib
{
    public class Node : IDisposable
    {
        public int? Value { get; set; }
        public Node? LeftChild { get; set; } = null;
        public Node? RightChild { get; set; } = null;
        public Node(int value) { Value = value; }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Id: " + Value;
        }
    }
}