namespace MyStack
{
    public class Stack<T>
    {
        public int MaxSize { get; set; }
        public T[] MyArray { get; set; }
        public int Top { get; set; }

        public Stack(int Size)
        {
            MaxSize = Size;
            Top = -1;
            MyArray = new T[MaxSize];
        }

        public bool IsEmpty()
        {
            return Top == -1;
        }

        public bool IsFull()
        {
            return Top + 1 == MaxSize;
        }

        public void Push(T Data)
        {
            if (IsFull())
            {
                Console.WriteLine("List is Full!");
                return;
            }
            MyArray[++Top] = Data;
        }

        public T? Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return default;
            }
            return MyArray[Top--];
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("List is Empty!");
            }
            return MyArray[Top];
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return;
            }

            Console.Write("{");
            for (int i = 0; i <= Top; i++)
            {
                Console.Write(MyArray[i]);
                if (i < Top)
                    Console.Write(", ");
            }
            Console.WriteLine("}");
        }

        public void Reverse()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return;
            }

            if (Top == 0)
            {
                Console.WriteLine("No Need to reverse");
                return;
            }

            T[] Temp = new T[Top + 1];
            int Index = 0;

            while (!IsEmpty())
            {
                Temp[Index++] = Pop();
            }

            for (int i = 0; i < Index; i++)
            {
                Push(Temp[i]);
            }
        }
    }
}
