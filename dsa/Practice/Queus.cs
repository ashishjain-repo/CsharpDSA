public class Queue<T>
{
    private T[] items;
    private int front;
    private int rear;
    private int count;
    private int capacity;
    public Queue(int Capacity)
    {
        this.capacity = Capacity;
        items = new T[capacity];
        front = 0;
        rear = -1;
        count = 0;
    }
    public void Enqueue(T element)
    {
        if(IsFull())
        {
            throw new InvalidOperationException("Queue is full. Cannot enque.");
        }
        rear = (rear + 1) % capacity;
        items[rear] = element;
        count++;
    }
    public T Dequeue()
    {
        if(IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty. Cannot dequeue");
        }
        T element = items[front];
        front = (front + 1) % capacity;
        count--;
        return element;
    }
    public T Peek()
    {
        if(IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty. Cannot peek.");
        }
        return items[front];
    }
    public bool IsEmpty()
    {
        return count == 0;
    }
    public bool IsFull()
    {
        return count == capacity;
    }
    public int GetSize()
    {
        return count;
    }
    public void Print()
    {
        System.Console.Write("{");
        for(int i = 0; i < count; i++)
        {
            System.Console.Write(items[i] + ",");
        }
        System.Console.Write("}\n");
    }
}