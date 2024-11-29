using System;
using MyQueue;
public class Program
{
	public static void Main(string[] args)
	{
		MyQueue.Queue<int> queue = new MyQueue.Queue<int>(5);
		queue.Enqueue(10);
		queue.Enqueue(20);
		queue.Enqueue(30);
		queue.Enqueue(40);
		queue.Enqueue(50);
		queue.Enqueue(60);
		System.Console.WriteLine(queue.Peek());
		queue.Dequeue();
		queue.Dequeue();
		queue.Dequeue();
		queue.Enqueue(100);
		queue.Enqueue(120);
		queue.Enqueue(130);
		queue.Enqueue(140);
		queue.Enqueue(150);
		System.Console.WriteLine(queue.Peek());
		System.Console.WriteLine(queue.Peek());
	}
}
