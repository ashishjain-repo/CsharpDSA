namespace MyStack
{
    public class Stack<T>
    {
        public int MaxSize {get; set;}
        public T[] MyStack {get; set;}
        public int Top {get; set;}
        public Stack(int Size)
        {
            MaxSize = Size;
            MyStack = new T[MaxSize];
            Top = -1;
        }
        public bool IsEmpty()
        {
            return Top == -1;
        }
        public bool IsFull()
        {
            return (Top + 1 == MaxSize);
        }
        public int Size()
        {
            return (IsEmpty() ? -1 : Top + 1);
        }
        public void Push(T Data)
        {
            if(IsFull())
            {
                System.Console.WriteLine("Stack is Full");
                return;
            }
            MyStack[++Top] = Data;
        }
        public T Pop()
        {
            if(IsEmpty())
            {
                System.Console.WriteLine("Stack is Empty!");
                return default;
            }
            return MyStack[Top--];
        }
        public T Peek()
        {
            if(IsEmpty())
            {
                System.Console.WriteLine("Stacl is Empty!");
                return default;
            }
            return MyStack[Top];
        }
        public int Search(T Data)
        {
            if(IsEmpty())
            {
                System.Console.WriteLine("Stack is Empty!");
                return default;
            }
            int Index = -1;
            for(int i = Top; i > -1; i--)
            {
                Index++;
                if(EqualityComparer<T>.Default.Equals(MyStack[i], Data))
                {
                    return Index + 1;
                }
            }
            return -1;
        }
        public void Reverse()
        {
            if(IsEmpty())
            {
                System.Console.WriteLine("Stack is Empty!");
                return;
            }
            T[] Temp = new T[Top + 1];
            int Index = 0;
            while(!IsEmpty())
            {
                Temp[Index++] = Pop();
            }
            for(int i = 0; i < Index; i++)
            {
                Push(Temp[i]);
            }
        }
        public void Print()
        {
            Console.Write("{");
            for(int i = Top; i > -1; i--)
            {
                System.Console.Write(MyStack[i]);
                if(i > 0)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("}\n");
        }

    }
}