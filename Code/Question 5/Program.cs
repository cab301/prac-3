namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerCollection collection = new CustomerCollection(3);
            collection.Display();
            Console.WriteLine("Adding customer...");
            collection.Insert("Dan", "Tran", "1234545678");
            collection.Display();

            Console.WriteLine("Adding customer...");
            collection.Insert("Jane", "Hoang", "12398721354");
            collection.Display();

            Console.WriteLine("Remove customer...");
            collection.Delete("Dan", "Tran");
            collection.Display();

        }
    }
}