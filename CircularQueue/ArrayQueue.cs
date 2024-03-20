using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueue
{
    internal class ArrayQueue : IQueue
    {
        public int Capacity => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        private int tailIndex;
        private int headIndex;
        private object[] data;

        public ArrayQueue()
        {
            tailIndex = 0;
            headIndex = 0;
            data = new object[Capacity];
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public object Dequeue()
        {
            throw new NotImplementedException();
        }

        public void Enqueue(object item)
        {
            data[tailIndex] = item;
            tailIndex = tailIndex + 1;
        }

        public object Head()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public bool IsFull()
        {
            throw new NotImplementedException();
        }
    }
}
