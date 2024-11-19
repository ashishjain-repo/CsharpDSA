public class LinkedList
{
    public Node First {get; set;}
    public void InsertFirst(int data)
    {
        // Create Node
        Node newNode = new Node();
        // Put data in the node
        newNode.Data = data;
        // Put the old node in next
        newNode.Next = First;
        // Make the first the new node
        First = newNode;
    }
}