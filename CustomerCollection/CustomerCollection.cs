using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCollection
{
    internal class CustomerCollection
    {
        public int Capacity { get; private set; }
        public int Count { get; private set; }

        private Customer[] data;

        public CustomerCollection(int capacity = 10)
        {
            Capacity = capacity;
            Count = 0;
            data = new Customer[Capacity];
        }

        public void Clear()
        {
            Count = 0;
            data = new Customer[Capacity];
        }

        public void Insert(string firstName, string lastName, string phoneNumber)
        {
            Customer newCustomer = new Customer(firstName, lastName, phoneNumber);
            Insert(newCustomer);
        }

        public void Insert(Customer customer)
        {
            if (IsFull()) return;
            data[Count] = customer;
            Count++;
        }

        public string Find(string firstName, string lastName)
        {
            for (int i = 0; i < Count; i++)
            {
                Customer current = data[i];
                if (current.FirstName.Equals(firstName)
                    && current.LastName.Equals(lastName))
                {
                    return current.PhoneNumber;
                }
            }
            return null;
        }

        public void Delete(string firstName, string lastName)
        {
            if (Find(firstName, lastName) == null) return;
            // Find the index to delete
            int index;
            for (index = 0; index < Count; index++)
            {
                Customer current = data[index];
                if (current.FirstName.Equals(firstName)
                    && current.LastName.Equals(lastName))
                {
                    break;
                }
            }
            // Shift everything after that index to the left
            for (; index < Count - 1; index++)
            {
                data[index] = data[index + 1];
            }
            Count--;
            //Delete(firstName, lastName);
        }

        public bool IsFull()
        {
            return Count == Capacity;
        }

        public void Display()
        {
            foreach (Customer customer in data)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
