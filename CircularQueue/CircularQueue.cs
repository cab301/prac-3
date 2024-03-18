using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueue
{
    /// <summary>
    /// Represents a data-containing in a linked list.
    /// </summary>
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
            Count = 0;
            tail = null;
        }

        public void Clear()
        {
            Count = 0;
            tail = null;
        }

        public object Dequeue()
        {
            if (IsEmpty()) return null;
            // Get the element from the head
            object result = tail.Next.Data;
            // Remove the head
            // If removing the only element
            // set tail to null (empty state)
            if (Count == 1)
            {
                tail = null;
            }
            // Otherwise, have the tail point to
            // the element after the head
            else
            {
                tail.Next = tail.Next.Next;
            }
            Count--;
            return result;
        }

        public void Enqueue(object item)
        {
            // Don't add when full
            if (Count == Capacity) return;
            Node newNode = new Node(item);
            if (IsEmpty())
            {
                tail = newNode;
                tail.Next = newNode;
            } 
            else
            {
                newNode.Next = tail.Next;
                tail.Next = newNode;
                tail = newNode;
            }
            Count++;
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
    }
}
