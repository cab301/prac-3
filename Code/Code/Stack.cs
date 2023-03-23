using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal class Stack : IStack
    {
        static int CAPACITY = 10;

        /// <summary>
        /// The inner data structure of a stack
        /// </summary>
        private double[] inner;
        private int capacity;
        private int size;

        public Stack()
        {
            capacity = CAPACITY;
            size = 0;
            inner = new double[capacity];
        }

        public int Size
        {
            get
            {
                return size;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return size == 0;
            }
        }

        public double Peek()
        {
            if (IsEmpty)
            {
                throw new ArgumentException("Cannot peek an empty stack");
            }
            return inner[size - 1];
        }

        public double Pop()
        {
            double element = Peek();
            size--;
            return element;
        }

        public void Push(double element)
        {
            if (size == capacity)
            {
                throw new ArgumentException("Cannot add the a full stack");
            }
            inner[size] = element;
            size++;
        }
    }
}
