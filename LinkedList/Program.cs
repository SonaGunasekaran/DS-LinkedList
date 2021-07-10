using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList");
            LinkedListNode<int> linkedList = new LinkedListNode<int>();
            //inserting elements at front
            linkedList.AddFront(70);
            linkedList.AddFront(30);
            linkedList.AddFront(56);
            //inserting elements at end
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);
            //inserting element at middle
            linkedList.InsertMiddle(35, 56);
            linkedList.Display();
            Console.Read();
        }
    }
}
