using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Queue : IQueue
    {
        const int CAPACITY = 10;
        private CircularLinkedList inner;
        private int capacity;
        private int count;

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public int Count => count;

        public Queue()
        {
            inner = new CircularLinkedList();
            count = 0;
            capacity = CAPACITY;
        }

        public void Clear()
        {
            inner = new CircularLinkedList();
            count = 0;
        }

        public object Dequeue()
        {
            count--;
            return inner.RemoveHead();
        }

        public void Enqueue(object item)
        {
            inner.Add(item);
            count++;
        }

        public object Head()
        {
            return inner.PeekHead();
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == capacity;
        }
    }
}
