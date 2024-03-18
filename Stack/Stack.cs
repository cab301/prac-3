//CAB301-Workshop 3
//Maolin Tang
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        private int capacity;
        private int numElements;
        private int[] data;


        /// constructor initializes stack
        public Stack(int capacity = 10) {
            this.capacity = capacity;
            numElements = 0;
            data = new int[capacity];
        }


        /// returns number of elements in the stack
        public int size()
        {
            return numElements;
        }

        /// return true if the stack is empty
        public bool empty()
        {
            return numElements == 0;
        }

        /// adds an element to the top of the stack
        public void push(int value)
        { //ensure to check if stack is full
            if (numElements == capacity) return;
            data[numElements] = value;
            numElements++;
        }

        /// returns the element from the top of the stack and removes it
        public int? pop()
        {
            if (empty()) return null;
            int result = data[numElements - 1];
            numElements--;
            return result;
        }

        /// returns the element from the top of the stack
        public int? peek()
        {
            if (empty()) return null;
            return data[numElements - 1];
        }

    }
}
