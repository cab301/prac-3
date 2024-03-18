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
            CustomerCollection customers = new CustomerCollection(5);

            // Case 1: Insert to empty collection
            // Expected: One member gets displayed
            Console.WriteLine("Insert to empty collection");
            customers.Insert("Dan", "Tran", "0123456789");
            customers.Display();

            // Case 2: Insert to collection of one
            Console.WriteLine("Insert to collection of one");
            customers.Insert("Jone", "Smith", "0123456788");
            customers.Display();

            // Case 3: Insert to collection of many but not full
            Console.WriteLine("Insert to collection of many (not full)");
            customers.Insert("Jane", "Smith", "0123456787");
            customers.Display();

            // Case 4: Insert to full collection
            Console.WriteLine("Insert to collection of many (not full)");
            customers.Insert("Jim", "Smith", "0123456786");
            customers.Insert("Jerry", "Smith", "0123456785");
            Console.WriteLine("Before");
            customers.Display();
            customers.Insert("James", "Smith", "0123456784");
            Console.WriteLine("After");
            customers.Display();
        }

        static void TestDelete()
        {
            CustomerCollection customers = new CustomerCollection(5);

            // Delete from empty collection
            Console.WriteLine("Remove from empty collection");
            Console.WriteLine("Before");
            customers.Display();
            customers.Delete("Dan", "Tran");
            Console.WriteLine("After");
            customers.Display();

            Console.WriteLine("Remove existing element from collection of one");
            customers.Insert("Dan", "Tran", "0123456789");
            Console.WriteLine("Before");
            customers.Display();
            customers.Delete("Dan", "Tran");
            Console.WriteLine("After");
            customers.Display();

            Console.WriteLine("Remove non-existing element from collection of one");
            customers.Insert("Dan", "Tran", "0123456789");
            Console.WriteLine("Before");
            customers.Display();
            customers.Delete("Jone", "Smith");
            Console.WriteLine("After");
            customers.Display();

            Console.WriteLine("Remove existing element from collection of many (not full)");
            customers.Insert("Dan", "Tran", "0123456789");
            customers.Insert("Jones", "Smith", "0123456786");
            customers.Insert("Jim", "Smith", "0123456786");
            customers.Insert("Jerry", "Smith", "0123456785");
            Console.WriteLine("Before");
            customers.Display();
            customers.Delete("Dan", "Tran");
            Console.WriteLine("After");
            customers.Display();

            Console.WriteLine("Remove non-existing element from collection of many (not full)");
            customers = new CustomerCollection(5);
            customers.Insert("Dan", "Tran", "0123456789");
            customers.Insert("Jones", "Smith", "0123456786");
            customers.Insert("Jim", "Smith", "0123456786");
            customers.Insert("Jerry", "Smith", "0123456785");
            Console.WriteLine("Before");
            customers.Display();
            customers.Delete("James", "Smith");
            Console.WriteLine("After");
            customers.Display();

            Console.WriteLine("Remove existing element from full collection");
            customers = new CustomerCollection(5);
            customers.Insert("Dan", "Tran", "0123456789");
            customers.Insert("Jones", "Smith", "0123456788");
            customers.Insert("Jim", "Smith", "0123456787");
            customers.Insert("Jerry", "Smith", "0123456786");
            customers.Insert("James", "Smith", "0123456785");
            Console.WriteLine("Before");
            customers.Display();
            customers.Delete("James", "Smith");
            Console.WriteLine("After");
            customers.Display();

            Console.WriteLine("Remove non-existing element from full collection");
            customers = new CustomerCollection(5);
            customers.Insert("Dan", "Tran", "0123456789");
            customers.Insert("Jones", "Smith", "0123456788");
            customers.Insert("Jim", "Smith", "0123456787");
            customers.Insert("Jerry", "Smith", "0123456786");
            customers.Insert("James", "Smith", "0123456785");
            Console.WriteLine("Before");
            customers.Display();
            customers.Delete("John", "Smith");
            Console.WriteLine("After");
            customers.Display();
        }

        static void TestFind()
        {

        }
    }
}
