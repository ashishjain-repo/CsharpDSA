public class Stack
{
    public int MaxSize {get; set;} // Array stacks you need a maxsize to init array
    public string[] StackArray {get; set;}
    public int Top {get; set;} // This keep track of the Top

    public Stack(int size)
    {
        this.MaxSize = size; // This holds constructur value
        this.StackArray = new string[MaxSize]; // Creates array with size
        this.Top = -1; // We give top -1 because array is zero index; if we do not it will skip first element
    }

    public void Push(string item)
    {
        Top++;
        StackArray[Top] = item;
    }
    public string Pop()
    {
        int oldTop = Top; // Placeholder
        Top--; // Decrement for the new top
        return StackArray[oldTop];
    }
    public string Peek()
    {
        return StackArray[Top];
    }
    public bool isEmpty()
    {
        return Top == 0;
    }
    public bool isFull()
    {
        return (MaxSize - 1 == Top);
    }

}