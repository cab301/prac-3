using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueue
{
    class Node
    {
        public Object Data { get; private set; }
        public Node Next { get; set; }
        public Node(Object data)
        {
            Data = data;
            Next = null;
        }
    }

    internal class CircularQueue : IQueue
    {
        public int Capacity { get; private set; }
        public int Count { get; private set; }
        private Node tail;

        public CircularQueue(int capacity = int.MaxValue)
        {
            Capacity = capacity;
            tail = null;
            Count = 0;
        }

        public void Clear()
        {
            tail = null;
            Count = 0;
        }

        public void Enqueue(object item)
        {
            if (IsFull()) return;
            // If not full, try to add to the queue

            // Case 1: Empty, new node becomes tail
            Node newNode = new Node(item);
            if (IsEmpty())
            {
                tail = newNode;
                tail.Next = tail;
            }
            // Case 2: Not empty, new node still becomes tail
            // But it also needs to point to the head (tail.Next)
            else
            {
                newNode.Next = tail.Next;
                tail.Next = newNode;
                tail = newNode;
            }
            Count++;
        }

        public object Dequeue()
        {
            if (IsEmpty()) return null;
            // Try to remove the head
            Object result = tail.Next.Data;
            if (Count == 1)
            {
                tail = null;
            }
            else
            {
                // Change head to element
                // after head
                tail.Next = tail.Next.Next;
            }
            Count--;
            return result;
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
            if (IsEmpty()) return;
            Node head = tail.Next;
            while (head != tail)
            {
                Console.WriteLine(head.Data);
                head = head.Next;
            }
            Console.WriteLine(tail.Data);
        }
    }
}
