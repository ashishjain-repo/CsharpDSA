public class Program
{
    public static void Main(string[] args)
    {
        /* MyStack.Stack<int> stack = new MyStack.Stack<int>(5);
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);
        stack.Push(60);
        stack.Print();
        stack.Pop();
        System.Console.WriteLine(stack.Peek());
        System.Console.WriteLine(stack.Size());
        System.Console.WriteLine(stack.Search(20));
        stack.Pop();
        stack.Pop();
        System.Console.WriteLine(stack.Peek());
        stack.Reverse();
        stack.Print(); */
        
        MyQueue.Queue<int> queue = new MyQueue.Queue<int>(5);
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Dequeue();
        queue.Enqueue(100);
        System.Console.WriteLine(queue.Peek());
    }
}