namespace MyQueue
{
    public class Queue<T>
    {
        public int MaxSize {get; set;}
        public T[] MyArray {get; set;}
        public int Front {get; set;}
        public int Back {get; set;}
        public int NItems {get; set;}
        public Queue(int Size)
        {
            this.MaxSize = Size;
            this.MyArray = new T[MaxSize];
            this.Front = 0;
            this.Back = -1;
            this.NItems = 0;
        }
        public bool IsEmpty()
        {
            return NItems == 0;
        }
        public bool IsFull()
        {
            return NItems == MaxSize;
        }
        public int Size()
        {
            return NItems;
        }
        public void Enqueue(T Data)
        {
            if(IsFull())
            {
                System.Console.WriteLine("Queue is Full!");
                return;
            }
            Back++;
            MyArray[Back] = Data;
            if(Back == MaxSize)
            {
                Back = 0;
            }
            NItems++;
        }
        public T Dequeue()
        {
            if(IsEmpty())
            {
                System.Console.WriteLine("Queue is Empty!");
                return default;
            }
            T Temp = MyArray[Front];
            Front++;
            if(Front == MaxSize)
            {
                Front = 0;
            }
            NItems--;
            return Temp;
        }
        public T Peek()
        {
            if(IsEmpty())
            {
                System.Console.WriteLine("Queue is Empty!");
                return default;
            }
            return MyArray[Front];
        }
        public void Print()
        {
            Console.Write("{");
            for(int i = Front; i < MaxSize; i++)
            {
                System.Console.Write(MyArray[i]);
                if(i < MaxSize - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("}");
        }
    }
}