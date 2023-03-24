using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_5
{
    internal class CustomerCollection
    {
        private Customer[] customers;
        private int capacity;
        private int count;

        public CustomerCollection(int capacity)
        {
            customers = new Customer[capacity];
            this.capacity = capacity;
        }

        public string Find(string firstName, string lastName)
        {
            foreach (Customer customer in customers)
            {
                if (firstName == customer.FirstName
                    && lastName == customer.LastName)
                {
                    return customer.Number;
                }
            }
            return "";
        }
        public void Insert(Customer newCustomer)
        {
            if (count == capacity) return;

            customers[count] = newCustomer;
            count++;
        }

        public void Insert(string firstName, string lastName, string number)
        {
            Insert(new Customer(firstName, lastName, number));
        }


        public void Delete(string firstName, string lastName)
        {
            // Nothing's here -> don't delete
            if (count == 0) return;

            int idxToDelete = -1;

            for (int i = 0; i < count; i++)
            {
                Customer customer = customers[i];
                if (customer.FirstName == firstName
                    && customer.LastName == lastName)
                {
                    idxToDelete = i;
                    break;
                }
            }

            // Didn't find -> don't delete
            if (idxToDelete == -1) return;

            // Shift everything to the left
            for (int i = idxToDelete; i < capacity - 1; i++)
            {
                customers[i] = customers[i + 1];
            }
            count--;
        }

        public void Display()
        {
            Console.WriteLine("Customer data: ");
            Console.WriteLine("First name \t Last name \t Number");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(customers[i]);
            }
            Console.WriteLine("{0} customer(s) found",
                count);
        }
    }
}
