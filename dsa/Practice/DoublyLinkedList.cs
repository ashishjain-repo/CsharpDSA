public class DoublyNode
{
    public int Data;
    public DoublyNode? Prev;
    public DoublyNode? Next;
    public DoublyNode(int data)
    {
        Data = data;
        Prev = null;
        Next = null;
    }
}
public class DoublyLinkedList
{
    public DoublyNode? Head;
    public DoublyNode? Tail;
    public DoublyLinkedList()
    {
        Head = null;
        Tail = null;
    }
    public void AddLast(int Element)
    {
        DoublyNode? newNode = new DoublyNode(Element);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            newNode.Prev = Tail;
            Tail = newNode;
        }
    }
    public void AddFirst(int Element)
    {
        DoublyNode? newNode = new DoublyNode(Element);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Head.Prev = newNode;
            newNode.Next = Head;
            Head = newNode;
        }
    }
    public void PrintForward()
    {
        if (Head == null)
        {
            System.Console.WriteLine("List is empty!");
            return;
        }
        DoublyNode? Current = Head;
        while (Current != null)
        {
            System.Console.Write(Current.Data + " -> ");
            Current = Current.Next;
        }
        System.Console.Write("null\n");
    }
    public void PrintBackward()
    {
        if (Tail == null)
        {
            System.Console.WriteLine("List is empty!");
            return;
        }
        DoublyNode? Current = Tail;
        while (Current != null)
        {
            System.Console.Write(Current.Data + " -> ");
            Current = Current.Prev;
        }
        System.Console.Write("null\n");
    }
    public void Remove(int data)
    {
        if (Head == null)
        {
            System.Console.WriteLine("List is empty!");
            return;
        }
        if (Head.Data == data)
        {
            if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
            }
            return;
        }
        DoublyNode? Current = Head;
        while (Current != null && Current.Data != data)
        {
            Current = Current.Next;
        }
        if (Current == null)
        {
            System.Console.WriteLine($"Element {data} not found in the list!");
            return;
        }
        if (Current == Tail)
        {
            Tail = Tail.Prev;
            Tail.Next = null;
            return;
        }
        Current.Prev.Next = Current.Next;
        Current.Next.Prev = Current.Prev;
    }
}