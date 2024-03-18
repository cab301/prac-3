namespace CircularQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestEnqueue();
            TestDequeue();
        }

        static void TestEnqueue()
        {
            CircularQueue queue = new CircularQueue();
            Console.WriteLine("Adding 4 to the queue");
            queue.Enqueue(4);
            queue.Display();

            Console.WriteLine("Adding 1 to the queue");
            queue.Enqueue(1);
            queue.Display();

            Console.WriteLine("Adding 3 to the queue");
            queue.Enqueue(3);
            queue.Display();

            Console.WriteLine("Adding 8 to the queue");
            queue.Enqueue(8);
            queue.Display();
        }

        static void TestDequeue()
        {
            CircularQueue queue = new CircularQueue();
            queue.Enqueue(4);
            queue.Enqueue(1);
            queue.Enqueue(3);
            queue.Enqueue(8);

            Console.WriteLine("Removing from the queue");
            queue.Dequeue();
            queue.Display();

            Console.WriteLine("Removing from the queue");
            queue.Dequeue();
            queue.Display();

            Console.WriteLine("Removing from the queue");
            queue.Dequeue();
            queue.Display();

            Console.WriteLine("Removing from the queue");
            queue.Dequeue();
            queue.Display();

            Console.WriteLine("Removing from the queue");
            queue.Dequeue();
            queue.Display();
        }
    }
}
