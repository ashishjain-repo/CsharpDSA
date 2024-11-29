namespace MyQueue
{
    public class Queue<T>
    {
        public int MaxSize { get; set; } // Capacity of the queue
        public T[] QueueArray { get; set; } // Array to hold elements
        public int Front { get; set; } // Points to the front element
        public int Rear { get; set; } // Points to the position for the next enqueue
        public int NItems { get; set; } // Tracks the current number of items in the queue

        public Queue(int size)
        {
            this.MaxSize = size;
            this.QueueArray = new T[MaxSize];
            this.Front = 0; // Front starts at 0
            this.Rear = 0; // Rear starts at 0
            this.NItems = 0; // Initially, no items are present
        }

        public void Enqueue(T data)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
                return;
            }

            QueueArray[Rear] = data; // Add element at the Rear position
            Rear++; // Move Rear to the next position
            if (Rear == MaxSize) // If Rear exceeds the last index, reset to 0
            {
                Rear = 0;
            }
            NItems++; // Increment the size tracker
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return default;
            }

            T temp = QueueArray[Front]; // Retrieve the element at the Front
            Front++; // Move Front to the next position
            if (Front == MaxSize) // If Front exceeds the last index, reset to 0
            {
                Front = 0;
            }
            NItems--; // Decrement the size tracker
            return temp;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return QueueArray[Front]; // Return the element at the Front
        }

        public bool IsEmpty()
        {
            return NItems == 0; // Queue is empty if no items are present
        }

        public bool IsFull()
        {
            return NItems == MaxSize; // Queue is full if all slots are used
        }

        public int Size()
        {
            return NItems; // Return the number of elements in the queue
        }
    }
}
