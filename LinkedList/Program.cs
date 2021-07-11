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
            //inserting element at middle
            linkedList.InsertMiddle(35, 56);
            //deleting First element in the List
            linkedList.RemoveAtFirst();
            //deleting Last element in the List
            linkedList.RemoveAtLast();
            //searching the element
            linkedList.Search(70);
            linkedList.Sort();
            linkedList.Display();
            Console.Read();
        }
    }
}
