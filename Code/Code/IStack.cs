using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal interface IStack
    {
        /// <summary>
        /// The size of the stack
        /// </summary>
        int Size { get; }
        /// <summary>
        /// If the stack is empty
        /// </summary>
        bool IsEmpty { get; }
        /// <summary>
        /// Add an element to the top of the stack
        /// </summary>
        /// <param name="element"></param>
        void Push(double element);
        /// <summary>
        /// Return the element on the top of the stack
        /// and removes it
        /// </summary>
        /// <returns>The element on top</returns>
        double Pop();
        /// <summary>
        /// Return the element on the top of the stack
        /// </summary>
        /// <returns></returns>
        double Peek();
    }
}
