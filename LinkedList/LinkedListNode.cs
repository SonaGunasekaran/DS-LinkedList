using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedListNode<T>
    {
        private Node<T> head;
        //Add the elements in the front
        public void AddFront( T value )
        {
            Node<T> newNode = new Node<T>(value);
            //check Whether head is null
            if(head==null)
            {
                 head=newNode;
            }
            //make newNode as head
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }
        //Add element at last
        public void AddLast(T value)
        {
            
            Node<T> newNode = new Node<T>(value);
            //check whether the head is null or not . 
            if (head == null)
            {
                head = newNode;
            }
            
            else
            {
                Node<T> temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }
        //Add element at middle
        public void InsertMiddle(T value, T midValue)
        {
            //creating the new node with given value
            Node<T> newNode = new Node<T>(value);
            //check whether the head is null or not . 
            if (head == null)
            {
                head = newNode;
            }
            
            else
            {
                // local variable to hold the address
                Node<T> preNode = head;
                Node<T> temp = preNode.Next;
                while (preNode.Next != null && !(preNode.value.Equals(midValue)))
                {
                    preNode = temp;
                    temp = temp.Next;
                }
                if (preNode.value.Equals(midValue))
                {
                    newNode.Next = preNode.Next;
                    preNode.Next = newNode;
                }
                else
                {
                    Console.WriteLine(" ", midValue, value);
                    preNode.Next = newNode;
                }
            }
        }

        public void Display()
        {
            Node<T> temp = head;
            if(head==null)
            {
                Console.WriteLine("List is empty!!");
            }
            else
            {
                while (temp != null)
                {
                   Console.WriteLine("" + temp.value);
                   temp = temp.Next;
                }
            }
        }
    }
}
