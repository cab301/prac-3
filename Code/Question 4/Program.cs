using System.Xml.Linq;

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestEnqueue();
            TestDequeue();
        }

        /// <summary>
        /// Precondition: There is nothing in the queue
        /// 
        /// Postcondition: The queue is full
        /// </summary>
        static void TestEnqueue()
        {
            // Precondition: empty queue
            Queue queue = new Queue();
            
            // Define expected result:
            // Queue is full after enqueue 10 elements

            // Do the test
            Console.WriteLine("Testing enqueue...");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enqueue {0}", i);
                queue.Enqueue(i);
            }
            Console.WriteLine("Queue is {0}",
                queue.IsFull() ? "full" : "not full");

            // Show actual result:
            // Queue is full after enqueue 10 elements
        }

        /// <summary>
        /// Precondition: Queue has 10 elements
        /// 
        /// Post condition: Queue has 0 element
        /// </summary>
        static void TestDequeue()
        {
            // Set up precondition:
            Queue queue = new Queue();
            // Set up the queue to test dequeue
            // Input: ints from 0 to 10
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }
            // Expected ouput: Queue removing elements from 0 to 10
            // and shows empty queue at the end
            Console.WriteLine("Testing dequeue...");
            for (int i = 0; i < 10; i++)
            {
                int element = (int) queue.Dequeue();
                Console.WriteLine("Dequeue {0}", element);
                Console.WriteLine("Next head {0}", queue.Head());
            }
            Console.WriteLine("Queue is {0}",
                queue.IsEmpty() ? "empty" : "not empty");
            // Actual result: Queue removing elements from 0 to 10
            // and shows empty queue at the end
        }
    }
}