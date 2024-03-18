using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCollection
{
    internal class CustomerCollection
    {
        public int Count { get; private set; }
        public int Capacity { get; private set; }

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

        /// <summary>
        /// Given a first name and last name, find the contact phone number.
        /// Implements a sequential search algorithm.
        /// </summary>
        /// <param name="firstName">The first name of the customer.</param>
        /// <param name="lastName">The last name of the customer.</param>
        /// <returns>The contact phone number, or null if not found/</returns>
        public string Find(string firstName, string lastName)
        {
            for (int i = 0; i < Count; i++)
            {
                Customer customer = data[i];
                if (customer == null) continue;
                if (customer.FirstName.Equals(firstName)
                    && customer.LastName.Equals(lastName))
                {
                    return customer.PhoneNumber;
                }
            }
            return null;
        }

        /// <summary>
        /// Insert the customer to the last position in the collection.
        /// </summary>
        /// <param name="customer">The customer to insert.</param>
        public void Insert(Customer customer)
        {
            if (Count == Capacity)
            {
                Console.WriteLine("Cannot insert to full collection.");
                return;
            }
            data[Count] = customer;
            Count++;
        }

        /// <summary>
        /// Insert the customer with given details to the last position in
        /// the collection.
        /// </summary>
        /// <param name="firstName">The first name of the customer.</param>
        /// <param name="lastName">The last name of the customer.</param>
        /// <param name="phoneNumber">The contact phone of the customer.</param>
        public void Insert(string firstName, string lastName, string phoneNumber)
        {
            Insert(new Customer(firstName, lastName, phoneNumber));
        }

        /// <summary>
        /// Remove a customer from the collection if found.
        /// </summary>
        /// <param name="firstName">The first name of the customer.</param>
        /// <param name="lastName">The last name of the customer.</param>
        /// <returns>True on success, false otherwise.</returns>
        public bool Delete(string firstName, string lastName)
        {
            // Only delete if the customer exists
            if (Find(firstName, lastName) == null) return false;
            // Find the index of the customer to remove
            int index;
            for (index = 0; index < Count; index++)
            {
                Customer customer = data[index];
                if (customer.FirstName.Equals(firstName)
                    && customer.LastName.Equals(lastName))
                {
                    break;
                }
            }
            // Shift all elements from the right of the customer
            // by 1 position to the left
            for (index = 0; index < Count; index++)
            {
                data[index] = data[index + 1];
            }
            Count--;
            return true;
        }

        /// <summary>
        /// Prints all customers in the collection.
        /// </summary>
        public void Display()
        {
            foreach (Customer customer in data)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
