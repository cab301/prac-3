using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal interface IQueue
    {
        /* Pre: true
        * Post: return the capacity of the queue
        */
        int Capacity { get; }
        /* Pre: true
        * Post: return the number of objects stored the queue
        */
        int Count { get; }
        /* Pre: true
        * Post: return true if the queue is empty;
        * otherwise, return false.
        */
        bool IsEmpty();
        /* Pre: true
        * Post: return true if the queue is full;
        * otherwise, return false.
        */
        bool IsFull();
        /* Pre: the queue is not full
        * Post: Object item is added to the head of the queue
        */
        void Enqueue(Object item);
        /* Pre: the queue is not empty
        * Post: the rear item is removed from the queue
        */
        Object Dequeue();
        /* Pre: the queue is not empty
        * Post: return the head item of the queue
        */
        Object Head();
        /* Pre: true
        * Post: the queue becomes empty
        */
        void Clear();
    }
}
