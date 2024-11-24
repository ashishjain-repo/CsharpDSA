public class MyNode
{
    public int Data;
    public MyNode? Next;
    public MyNode(int data)
    {
        Data = data;
        Next = null;
    }
}
public class MyLinkedList
{
    private MyNode? Head;
    public MyLinkedList()
    {
        Head = null;
    }
    public void AddLast(int data)
    {
        MyNode? newNode = new MyNode(data);
        if(Head == null)
        {
            Head = newNode;
        }
        else
        {
            MyNode? Current = Head;
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
        else
        {
            MyNode? Current = Head;
            while(Current != null)
            {
                Console.Write(Current.Data + " -> ");
                Current = Current.Next;
            }
            System.Console.Write("null\n");
        }
    }
    public void Remove(int data)
    {
        if(Head == null)
        {
            System.Console.WriteLine("List is empty!");
            return;
        }
        if(Head.Data == data)
        {
            Head = Head.Next;
        }
        MyNode? Current = Head;
        while(Current.Next != null && Current.Next.Data != data)
        {
            Current = Current.Next;
        }
        if(Current.Next != null)
        {
            Current.Next = Current.Next.Next;
        }
    }
}