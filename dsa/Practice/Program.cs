public class Program
{
    public static void Main(string[] args)
    {
        // 1. Basic Algorithm and Problem Solving
        /* Console.WriteLine(BasicAlgoProbSolve.ReverseString("Ashish Jain"));
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
        */

    /*
        // 2. Data Structures
        int[] rotateArray1 = ArrayManipulation.RotateArray([1, 2, 3, 4, 5], 2);
        int[] rotateArray2 = ArrayManipulation.RotateArray([1, 2, 3, 4, 5], 4);
        Console.WriteLine($"[{string.Join(", ", rotateArray1)}]");
        Console.WriteLine($"[{string.Join(", ", rotateArray2)}]");

        int[] sortedList1 = ArrayManipulation.MergeArray([1, 3, 5], [2, 4, 6]);
        int[] sortedList2 = ArrayManipulation.MergeArray([1, 5, 9], [3, 7, 11]);
        Console.WriteLine($"[{string.Join(", ", sortedList1)}]");
        Console.WriteLine($"[{string.Join(", ", sortedList2)}]"); */

MyQueue.Queue<int> queue = new MyQueue.Queue<int>(5);
queue.Enqueue(10);
queue.Enqueue(20);
queue.Enqueue(30);
queue.Enqueue(40);
queue.Dequeue();
queue.Enqueue(50);
System.Console.WriteLine(queue.Peek());
queue.Print();
    }
}