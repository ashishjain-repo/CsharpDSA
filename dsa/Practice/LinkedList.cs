public class Node
{
    public int Data;
    public Node? Next;
    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}
public class LinkedList
{
    private Node? Head;
    public LinkedList()
    {
        Head = null;
    }
    public void AddLast(int data)
    {
        Node newNode = new Node(data);
        if(Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node? Current = Head;
            while(Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
        }
    }
    public void PrintList()
    {
        if(Head == null)
        {
            System.Console.WriteLine("List is empty!");
            return;
        }
        Node? Current = Head;
        while(Current != null)
        {
            System.Console.Write(Current.Data + " -> ");
            Current = Current.Next;
        }
        System.Console.Write("null\n");
    }
    public void Reverse()
    {
        Node? Prev = null;
        Node? Current = Head;
        while(Current != null)
        {
            (Prev, Current, Current.Next) = (Current, Current.Next, Prev);
        }
        Head = Prev;
    }
    public bool HasCycle()
    {
        Node? slow = Head;
        Node? fast = Head;
        while(fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
            if(slow == fast)
            {
                System.Console.WriteLine("Cycle Detected");
                return true;
            } 
        }
        System.Console.WriteLine("No Cycle Detected");
        return false;
    }
}