public class Stack
{
    public int MaxSize { get; set; }
    public int[] IntArray { get; set; }
    public int Top { get; set; }
    public Stack(int size)
    {
        MaxSize = size;
        IntArray = new int[MaxSize];
        Top = -1;
    }
    public void Push(int data)
    {
        try
        {
            Top++;
            IntArray[Top] = data;
        }
        catch (IndexOutOfRangeException)
        {
            System.Console.WriteLine("Stack is Full!");
            return;
        }
    }
    public int Pop()
    {
        try
        {
            int OldTop = Top;
            Top--;
            return IntArray[OldTop];
        }
        catch (IndexOutOfRangeException)
        {
            System.Console.WriteLine("Stack is Empty!");
            return 0;
        }
    }
    public void PrintStack()
    {
        if (Top == -1)
        {
            System.Console.WriteLine("Empty Stack!");
            return;
        }
        System.Console.Write("[TOP] -> ");
        for (int i = 0; i <= Top; i++)
        {
            System.Console.Write(IntArray[i] + " -> ");
        }
        System.Console.Write("[END]\n");
    }
    public int Peek()
    {
        return IntArray[Top];
    }
    public bool isEmpty()
    {
        return Top == -1;
    }
    public bool isFull()
    {
        return (Top + 1 == MaxSize);
    }
    public void Clear()
    {
        Top = -1;
    }
    public int Size()
    {
        return Top + 1;
    }
    public void Reverse()
    {
        if(isEmpty())
        {
            return;
        }
        int[] TempArray = new int[Size()];
        int Index = 0;
        while(!isEmpty())
        {
            TempArray[Index++] = Pop();
        }
        for(int i = 0; i < Index; i++)
        {
            Push(TempArray[i]);
        }
    }
    
}