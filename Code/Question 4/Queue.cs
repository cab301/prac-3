using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Queue : IQueue
    {
        private CircularLinkedList data;

        private int capacity;
        private int count;

        public Queue(int capacity = 10)
        {
            data = new CircularLinkedList();
            this.capacity = capacity;
            this.count = 0;
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public int Count 
        {
            get 
            { 
                return count;
            }
        }

        public void Clear()
        {
            data = new CircularLinkedList();
            this.count = 0;
        }

        public object Dequeue()
        {
            object head = Head();
            data.RemoveHead();
            count--;
            //if (IsEmpty()) Clear();
            return head;
        }

        public void Enqueue(object item)
        {
            data.Add(item);
            count++;
        }

        public object Head()
        {
            if (IsEmpty())
                throw new ArgumentException("Cannot find head of empty queue");
            return data.Tail.Next.Data;
        }

        public object Tail()
        {
            return data.Tail.Data;
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
