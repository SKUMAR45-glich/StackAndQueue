using System;

namespace StackandQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Queue Implementation");
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            Console.WriteLine();
            linkedListQueue.Dequeue();
            linkedListQueue.Dequeue();
            linkedListQueue.Dequeue();
            linkedListQueue.Display();
        }
    }
}
