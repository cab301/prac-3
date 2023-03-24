namespace Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("pushing " + i);

                stack.Push(i);
                Console.WriteLine("Top of stack holds " + stack.Peek());
            }
            Console.WriteLine("Stack size = " + stack.Size());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("popping " + stack.Pop());
            }

            Console.WriteLine("Stack size = " + stack.Size());

            if (stack.Empty())
            {
                Console.WriteLine("The stack is now empty");
            }

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("pushing " + i);
                stack.Push(i);
            }

            Console.WriteLine("Peeking at the top of the stack the element is " + stack.Peek());
            Console.ReadLine();
        }
    }
}