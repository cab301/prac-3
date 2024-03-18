namespace CircularQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestDequeue();
        }

        static void TestEnqueue()
        {
            // Set up
            CircularQueue queue = new CircularQueue();
            queue.Enqueue(4);
            Console.WriteLine($"There are {queue.Count} elements");
            queue.Display();

            queue.Enqueue(1);
            Console.WriteLine($"There are {queue.Count} elements");
            queue.Display();

            queue.Enqueue(3);
            Console.WriteLine($"There are {queue.Count} elements");
            queue.Display();

            queue.Enqueue(8);
            Console.WriteLine($"There are {queue.Count} elements");
            queue.Display();
        }

        static void TestDequeue()
        {
            CircularQueue queue = new CircularQueue();
            queue.Enqueue(4);
            queue.Enqueue(1);
            queue.Enqueue(3);
            queue.Enqueue(8);

            queue.Dequeue();
            Console.WriteLine($"There are {queue.Count} elements");
            queue.Display();

            queue.Dequeue();
            Console.WriteLine($"There are {queue.Count} elements");
            queue.Display();

            queue.Dequeue();
            Console.WriteLine($"There are {queue.Count} elements");
            queue.Display();

            queue.Dequeue();
            Console.WriteLine($"There are {queue.Count} elements");
            queue.Display();
        }
    }
}
