using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList");
            LinkedListNode<int> linkedList = new LinkedListNode<int>();
            linkedList.AddFront(30);
            linkedList.AddFront(70);
            linkedList.AddFront(56);
            linkedList.Display();
        }
    }
}
