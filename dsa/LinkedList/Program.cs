public class Program
{
    public static void Main(string[] args)
    {
        Node nodeA = new Node();
        nodeA.Data = 323;
        Node nodeB = new Node();
        nodeB.Data = 498;
        Node nodeC = new Node();
        nodeC.Data = 651;
        Node nodeD = new Node();
        nodeD.Data = 912;

        nodeA.Next = nodeB;
        nodeB.Next = nodeC;
        nodeC.Next = nodeD;
        nodeD.Next = null;

    }
}