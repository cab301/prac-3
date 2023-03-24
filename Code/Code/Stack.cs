using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal class Stack
    {
        static int CAPACITY = 10;
        private int capacity;
        private int numElements;
        private int[] inner;


        /// constructor initializes stack
        public Stack()
        {
            capacity = CAPACITY;
            numElements = 0;
            inner = new int[CAPACITY];
        }


        /// returns number of elements in the stack
        public int Size()
        {
            return numElements;
        }

        /// return true if the stack is empty
        public bool Empty()
        {
            return numElements == 0;
        }

        /// adds an element to the top of the stack
        public void Push(int value)
        { //ensure to check if stack is full
            inner[numElements] = value;
            numElements++;
        }

        /// returns the element from the top of the stack and removes it
        public int Pop()
        {
            int topElement = Peek();
            numElements--;
            return topElement;
        }

        /// returns the element from the top of the stack
        public int Peek()
        {
            if (numElements == 0)
                throw new Exception("Cannot peek empty stack");
            return inner[numElements - 1];
        }
    }
}
