namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Dequeue();


            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Enqueue " + i);

                queue.Enqueue(i);
                Console.WriteLine("Queue head: " + queue.Head());
                Console.WriteLine("Queue tail: " + queue.Tail());
            }
            Console.WriteLine("Queue size = " + queue.Count);

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Queue head: " + queue.Head());
                Console.WriteLine("Queue tail: " + queue.Tail());
                Console.WriteLine("Dequeue " + queue.Dequeue());
            }

            Console.WriteLine("Queue size = " + queue.Count);

            if (queue.IsEmpty())
            {
                Console.WriteLine("The queue is now empty");
            }

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Enqueue " + i);
                queue.Enqueue(i);
            }

            Console.WriteLine("Peeking at the head of the queue the element is " + queue.Head());
            Console.ReadLine();
        }
    }
}