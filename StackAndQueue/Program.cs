using System;

namespace StackAndQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures");

            /*Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();

            stack.Peak();
            stack.Pop();
            stack.Display();*/

            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display(); ;

            queue.Dequeue();
            queue.Display();
        }
    }
}