using System;

namespace StackandQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Stack Implementation");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
        }
    }
}
