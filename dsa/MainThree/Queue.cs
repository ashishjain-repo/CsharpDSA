namespace MyQueue
{
    public class Queue<T>
    {
        public int MaxSize { get; set; }
        public T[] MyQueue { get; set; }
        public int Front { get; set; }
        public int Back { get; set; }
        public int NItem { get; set; }
        public Queue(int Size)
        {
            MaxSize = Size;
            MyQueue = new T[MaxSize];
            Front = 0;
            Back = 0;
            NItem = 0;
        }
        public bool IsFull()
        {
            return NItem == MaxSize;
        }
        public bool IsEmpty()
        {
            return NItem == 0;
        }
        public int Size()
        {
            return NItem;
        }
        public void Enqueue(T Data)
        {
            if(IsFull())
            {
                System.Console.WriteLine("Queue is Full!");
                return;
            }
            MyQueue[Back++] = Data;
            if(Back == MaxSize)
            {
                Back = 0;
            }
            NItem++;
        }
        public T Dequeue()
        {
            if(IsEmpty())
            {
                System.Console.WriteLine("Queue is Empty!");
                return default;
            }
            T Temp = MyQueue[Front++];
            if(Front == MaxSize)
            {
                Front = 0;
            }
            NItem--;
            return Temp;
        }
        public T Peek()
        {
            if(IsEmpty())
            {
                System.Console.WriteLine("Queue is Empty!");
                return default;
            }
            return MyQueue[Front];
        }

    }

}