namespace BinaryTree.Lib
{
    public partial class Node<O> : IDisposable
    {
        public O? Value { get; set; }
        public Node<O>? LeftNode { get; set; }
        public Node<O>? RightNode { get; set; }
        public Node(O value) { Value = value; }

        public Node(O value, Node<O>? leftNode, Node<O>? rightNode) : this(value)
        {
            LeftNode = leftNode;
            RightNode = rightNode;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public void SetLeftNode(Node<O> node) => LeftNode = node;
        public void SetRightNode(Node<O> node) => RightNode = node;

        public Node<O>? GetLeftNode() => LeftNode;
        public Node<O>? GetRightNode() => RightNode;

        public override string? ToString() => "Id: " + Value?.ToString();
    }
}