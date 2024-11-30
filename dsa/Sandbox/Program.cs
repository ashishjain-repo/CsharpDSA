class Node
{
  public int Data { get; set; }
  public Node? Next { get; set; }

  public Node(int data)
  {
    Data = data;
    Next = null;
  }
  public void DisplayList()
  {
    Console.WriteLine(Data);
  }
}

class LinkedList
{
  private Node? Head;

  public LinkedList()
  {
    Head = null;
  }

  public void InsertAtBeginning(int data)
  {
    Node newNode = new Node(data);
    newNode.Next = Head;
    Head = newNode;
  }

  public Node DeleteFirst()
  {
    Node? Temp = Head;
    Head = Head.Next;
    return Temp;
  }

  public void Display()
  {
    Node? Current = Head;
    while (Current != null)
    {
      Current.DisplayList();
      Current = Current.Next;
    }
  }
}

public class Program
{
  public static void Main(string[] args)
  {
    LinkedList linkedlist = new LinkedList();
    linkedlist.InsertAtBeginning(1);
    linkedlist.InsertAtBeginning(2);
    linkedlist.InsertAtBeginning(3);
    linkedlist.InsertAtBeginning(4);
    linkedlist.InsertAtBeginning(5);
    linkedlist.InsertAtBeginning(6);
    linkedlist.DeleteFirst();
    linkedlist.Display();
  }
}