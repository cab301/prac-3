using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class CircularLinkedList
    {
        public Node Tail { get; private set; }

        //private Node head;

        public CircularLinkedList()
        {
            Tail = null;
        }

        /// <summary>
        /// Add an object to the end of the linked list
        /// </summary>
        /// <param name="obj">The object to add</param>
        public void Add(Object obj)
        {
            if (Tail == null)
            {
                Tail = new Node(obj);
                Tail.Next = Tail;
            } else
            {
                Node newNode = new Node(obj);
                Node oldHead = Tail.Next;
                // Point tail to new node
                Tail.Next = newNode;
                // point new node to old head
                newNode.Next = oldHead;
                Tail = newNode;
            }
        }

        public void RemoveHead()
        {
            if (Tail.Next == Tail) Tail = null;
            else // Point the tail to the node after the head
            Tail.Next = Tail.Next.Next;
        }

        //// There is no point implementing this method
        //public void RemoveTail()
        //{
        //    // Find the node before the tail
        //    // Make that the new tail, point to the head
        //}

        public override string ToString()
        {
            string str = "";
            Node current = Tail.Next;
            do
            {
                str += current.Data.ToString() + ", ";
            } while (current != Tail.Next);
            return str;
        }
    }

    class Node
    {
        public Object Data { get; set; }
        public Node Next { get; set; }

        public Node(Object data)
        {
            Data = data;
        }
    }
}
