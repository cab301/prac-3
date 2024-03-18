namespace CustomerCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestInsert();
            TestDelete();
        }

        static void TestInsert()
        {
            // Set up
            CustomerCollection customers = new CustomerCollection(5);

            // Testing
            // Insert to empty
            // Expect one customer displayed
            Console.WriteLine("Insert to empty collection.");
            customers.Insert("Dan", "Tran", "0123456789");
            customers.Display();

            // Insert to collection of one
            // Expect two customers displayed
            Console.WriteLine("Insert to collection of one.");
            customers.Insert("Jone", "Smith", "0123456788");
            customers.Display();

            // Insert to collection of many, but not full
            // Expect three customers displayed
            Console.WriteLine("Insert to collection of many.");
            customers.Insert("Joe", "Smith", "0123456787");
            customers.Display();

            // Insert to full
            customers.Insert("Jim", "Smith", "0123456786");
            customers.Insert("Jerry", "Smith", "0123456785");
            Console.WriteLine("Before insert to full collection.");
            customers.Display();
            Console.WriteLine("After insert to full collection.");
            customers.Insert("James", "Smith", "0123456787");
            customers.Display();
        }

        static void TestDelete()
        {
            // Set up
            CustomerCollection customers = new CustomerCollection(5);

            // Delete from empty
            Console.WriteLine("Deleting from empty collection");
            Console.WriteLine("Before");
            customers.Display();
            bool result = customers.Delete("Dan", "Tran");
            Console.WriteLine("After");
            customers.Display();
            Console.WriteLine(result);

            // Delete non-existing
            Console.WriteLine("Delete non-existing customer");
            customers.Insert("Jone", "Smith", "0123456788");
            Console.WriteLine("Before");
            customers.Display();
            result = customers.Delete("Dan", "Tran");
            Console.WriteLine("After");
            customers.Display();
            Console.WriteLine(result);

            // Delete existing
            Console.WriteLine("Delete existing customer from collection of one");
            Console.WriteLine("Before");
            customers.Display();
            result = customers.Delete("Jone", "Smith");
            Console.WriteLine("After");
            customers.Display();
            Console.WriteLine(result);

            // Delete existing from collection of many but not full
            Console.WriteLine("Delete existing from collection of many.");
            customers.Insert("Joe", "Smith", "0123456787");
            customers.Insert("Jim", "Smith", "0123456786");
            customers.Insert("Jerry", "Smith", "0123456785");
            Console.WriteLine("Before");
            customers.Display();
            result = customers.Delete("Jerry", "Smith");
            Console.WriteLine("After");
            customers.Display();

            // Delete non-existing from collection of many but not full

            // Delete existing from full collection

            // Delete non-existing from full collection
        }

        static void TestSearch()
        {

        }
    }
}
