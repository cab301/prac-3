using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CircularQueue
{
    class Node
    {
        public Object Data { get; private set; }
        public Node Next { get; set; }
        public Node(object data)
        {
            Data = data;
            Next = null;
        }
    }

    internal class CircularQueue : IQueue
    {
        public int Capacity { get; private set; }
        public int Count { get; private set; }

        // Reference to the tail only
        private Node tail;

        public CircularQueue(int capacity = int.MaxValue)
        {
            Capacity = capacity;
            Count = 0;
            tail = null;
        }

        public void Clear()
        {
            // The empty state
            Count = 0;
            tail = null;
        }

        public void Enqueue(object item)
        {
            if (IsFull()) return;
            Node newNode = new Node(item);
            if (IsEmpty())
            {
                tail = newNode;
                tail.Next = tail;
            }
            else
            {
                newNode.Next = tail.Next; // 1
                tail.Next = newNode;      // 2
                tail = newNode;           // 3
            }
            Count++;
        }

        public object Dequeue()
        {
            if (IsEmpty()) return null;
            // Data from the head
            object data = tail.Next.Data; 
            // Removing the only and last element
            // by revert to "empty state"
            if (Count == 1)
            {
                tail = null;
            }
            // Else, remove the head by deleting any
            // reference to it
            else
            {
                tail.Next = tail.Next.Next;
            }
            Count--;
            return data;
        }

        public object Head()
        {
            if (IsEmpty()) return null;
            return tail.Next.Data;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public bool IsFull()
        {
            return Count == Capacity;
        }
        public void Display()
        {
            Node current = tail.Next;
            while (current != tail)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
            Console.WriteLine(tail.Data);
        }
    }
}
