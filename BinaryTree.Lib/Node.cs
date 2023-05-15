namespace BinaryTree.Lib
{
    public class Node : IDisposable
    {
        public int ID { get; set; }
        public Node(int id) { this.ID = id; }

        public Node? LeftNode { get; set; }
        public Node? RightNode { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}