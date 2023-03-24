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

        public void Add(Object data)
        {
            // If there is nothing in the linked list,
            // make the new node the tail
            if (Tail == null)
            {
                Tail = new Node(data);
                Tail.Next = Tail;
            }
            // Otherwise, add to the tail
            else
            {
                Node newNode = new Node(data);
                newNode.Next = Tail.Next;
                Tail.Next = newNode;
                Tail = newNode;
            }
        }

        public Object RemoveHead()
        {
            // Data from the head
            Object data = Tail.Next.Data;
            // Point the tail to the node after the head
            // head = Tail.Next
            if (Tail.Next == Tail) Tail = null;
            else Tail.Next = Tail.Next.Next;
            return data;
        }

        public Object PeekHead()
        {
            return Tail?.Next.Data;
        }
    }

    class Node
    {
        public Object Data { get; set; }
        public Node Next { get; set; }
        public Node(object data)
        {
            Data = data;
            Next = null;
        }
    }
}
