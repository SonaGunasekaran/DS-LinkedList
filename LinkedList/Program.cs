using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList");
            LinkedListNode<int> linkedList = new LinkedListNode<int>();
            linkedList.AddFront(70);
            linkedList.AddFront(30);
            linkedList.AddFront(56);
            
            LinkedListNode<int> linkedList1 = new LinkedListNode<int>();
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);
            linkedList.Display();
        }
    }
}
