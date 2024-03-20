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
            int[] elements = { 5, 4, 1, 3, 6, 2 };
            foreach (int number in elements)
            {
                Console.WriteLine($"{number} entered the queue");
                queue.Enqueue(number);
                queue.Display();
            }

        }
        static void TestDequeue()
        {
            CircularQueue queue = new CircularQueue();
            int[] elements = { 5, 4, 1, 3, 6, 2 };
            foreach (int number in elements)
            {
                queue.Enqueue(number);
            }
            Console.WriteLine("Dequeuing from");
            queue.Display();

            while (queue.Count > 0)
            {
                int element = (int)queue.Dequeue();
                Console.WriteLine($"{element} left the queue");
            }
        }
    }
}
