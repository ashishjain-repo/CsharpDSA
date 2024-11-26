using MyStack;
public class Program
{
    public static void Main(string[] args)
    {
        // 1. Basic Algorithm and Problem Solving
        Console.WriteLine(BasicAlgoProbSolve.ReverseString("Ashish Jain"));
        Console.WriteLine(BasicAlgoProbSolve.ReverseString("This is a Tea Pot"));

        Console.WriteLine(BasicAlgoProbSolve.LargeElement([1, 2, 10, 30, 2, 5, 0]));
        Console.WriteLine(BasicAlgoProbSolve.LargeElement([100, 1000, 432, 121, 677, 1001]));

        Console.WriteLine(BasicAlgoProbSolve.NumOccurence([5, 10, 33, 12, 5, 11, 90, 105, 43, 5], 5));
        Console.WriteLine(BasicAlgoProbSolve.NumOccurence([5, 10, 12, 33, 12, 5, 11, 90, 105, 12, 43, 5, 12], 12));

        Console.WriteLine(BasicAlgoProbSolve.MissingNumber([1, 2, 4, 5, 3, 7, 10, 8, 6]));
        Console.WriteLine(BasicAlgoProbSolve.MissingNumber([1, 2, 4, 5, 3, 9, 10, 8, 6]));

        Console.WriteLine(BasicAlgoProbSolve.PalindromeCheck("RAT"));
        Console.WriteLine(BasicAlgoProbSolve.PalindromeCheck("RAR"));

        int[] sumOfTwo1 = BasicAlgoProbSolve.SumOfTwo([1, 2, 3, 3], 6);
        int[] sumOfTwo2 = BasicAlgoProbSolve.SumOfTwo([1, 2, 3, 3], 5);
        Console.WriteLine($"Index 1: {sumOfTwo1[0]}, Index 2: {sumOfTwo1[1]}");
        Console.WriteLine($"Index 1: {sumOfTwo2[0]}, Index 2: {sumOfTwo2[1]}");

        Console.WriteLine(BasicAlgoProbSolve.SecondLargest([10, 20, 40, 30, 44, 21]));
        Console.WriteLine(BasicAlgoProbSolve.SecondLargest([33, 546, 11, 98, 54, 7]));

        int[] reverseArray1 = BasicAlgoProbSolve.ReverseArray([10, 20, 30, 40, 50]);
        int[] reverseArray2 = BasicAlgoProbSolve.ReverseArray([43, 11, 678, 123, 11, 678, 844]);
        Console.WriteLine($"[{string.Join(", ", reverseArray1)}]");
        Console.WriteLine($"[{string.Join(", ", reverseArray2)}]");

        // 2. Data Structures
        int[] rotateArray1 = ArrayManipulation.RotateArray([1, 2, 3, 4, 5], 2);
        int[] rotateArray2 = ArrayManipulation.RotateArray([1, 2, 3, 4, 5], 4);
        Console.WriteLine($"[{string.Join(", ", rotateArray1)}]");
        Console.WriteLine($"[{string.Join(", ", rotateArray2)}]");

        int[] sortedList1 = ArrayManipulation.MergeArray([1, 3, 5], [2, 4, 6]);
        int[] sortedList2 = ArrayManipulation.MergeArray([1, 5, 9], [3, 7, 11]);
        Console.WriteLine($"[{string.Join(", ", sortedList1)}]");
        Console.WriteLine($"[{string.Join(", ", sortedList2)}]");

        MyLinkedList linkedList = new MyLinkedList();
        linkedList.AddLast(10);
        linkedList.AddLast(20);
        linkedList.AddLast(30);
        linkedList.AddLast(100);
        linkedList.AddLast(40);
        linkedList.AddLast(50);
        linkedList.AddLast(60);
        linkedList.AddLast(70);
        linkedList.Remove(100);
        linkedList.AddLast(80);
        linkedList.AddLast(90);
        linkedList.PrintList();

        DoublyLinkedList doubly = new DoublyLinkedList();
        System.Console.WriteLine();
        doubly.AddFirst(10);
        doubly.AddFirst(20);
        doubly.AddFirst(30);
        doubly.AddLast(40);
        doubly.Remove(20);
        doubly.PrintForward();
        doubly.PrintBackward();

        LinkedList linked = new LinkedList();
        linked.AddLast(10);
        linked.AddLast(20);
        linked.AddLast(30);
        linked.Reverse();
        linked.PrintList();
        linked.HasCycle();

        /* // Stack
        Stack<int> stack = new Stack<int>(10);
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);
        stack.Push(60);
        stack.Push(70);
        stack.Push(80);
        stack.Push(90);
        stack.Push(100);
        System.Console.WriteLine(stack.Size());
        stack.Print();
        System.Console.WriteLine(stack.IsFull());
        System.Console.WriteLine(stack.Pop());
        System.Console.WriteLine(stack.Peek());
        stack.Print();
        stack.Clear();
        stack.Print();
        System.Console.WriteLine(stack.Size());

        Stack<int> random = new Stack<int>(10);
        random.Push(10);
        random.Push(20);
        random.Push(30);
        random.Push(40);
        random.Print();
        random.Reverse();
        random.Print(); */

        Queue<int> myQueue = new Queue<int>(10);
        myQueue.Enqueue(10);
        myQueue.Enqueue(20);
        myQueue.Enqueue(30);
        myQueue.Dequeue();
        myQueue.Print();

        MyStack.Stack<int> stack = new MyStack.Stack<int>(10);
        stack.Push(10);
        stack.Pop();
        stack.Pop();
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);
        stack.Push(60);
        stack.Push(70);
        stack.Push(80);
        stack.Push(90);
        stack.Push(100);
        stack.Push(110);
        stack.Push(120);
        stack.Push(140);
        stack.Print();
        Console.WriteLine(stack.Peek());
        stack.Reverse();
        Console.WriteLine(stack.Peek());
        stack.Pop();
        stack.Print();
    }
}