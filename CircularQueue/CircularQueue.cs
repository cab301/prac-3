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
            Count = 0;
            tail = null;
        }

        public void Clear()
        {
            Count = 0;
            tail = null;
        }

        public void Enqueue(object item)
        {
            if (IsFull()) return;
            // Try to add
            Node newNode = new Node(item);
            if (IsEmpty())
            {
                tail = newNode;
                tail.Next = tail;
            }
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
            object result = tail.Next.Data;
            if (Count == 1)
            {
                // Empty state
                tail = null;
            }
            else
            {
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
