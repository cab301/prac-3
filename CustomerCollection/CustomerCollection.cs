using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCollection
{
    internal class CustomerCollection
    {
        public int Count { get; private set; }
        public int Capacity { get; private set; }
        private Customer[] customers;
        public CustomerCollection(int capacity)
        {
            Capacity = capacity;
            Count = 0;
            customers = new Customer[Capacity];
        }
        public void Insert(Customer customer)
        {
            if (IsFull()) return;
            for (int i = 0; i <= Count; i++)
            {
                Customer c = customers[i];
                if (c is null)
                {
                    customers[i] = customer;
                    Count++;
                    return;
                }
            }
        }
        public void Insert(string firstName, string lastName, string phoneNumber)
        {
            Insert(new Customer(firstName, lastName, phoneNumber));
        }
        public string Find(string firstName, string lastName)
        {
            if (IsEmpty()) return null;
            foreach (Customer customer in customers)
            {
                if (customer is null) continue;
                if (customer.FirstName.Equals(firstName)
                    && customer.LastName.Equals(lastName))
                {
                    return customer.PhoneNumber;
                }
            }
            return null;
        }
        public void Delete(string firstName, string lastName)
        {
            if (IsEmpty()) return;
            if (Find(firstName, lastName) == null) return;
            for (int i = 0; i < Count; i++)
            {
                Customer customer = customers[i];
                if (customer.FirstName.Equals(firstName)
                    && customer.LastName.Equals(lastName))
                {
                    customers[i] = null;
                    Count--;
                    return;
                }
            }
        }
        public bool IsFull()
        {
            return Count == Capacity;
        }
        public bool IsEmpty() => Count == 0;
        public void Display()
        {
            Console.WriteLine($"There are {Count} customers");

            for (int index = 0; index < Capacity; index++)
            {
                Customer customer = customers[index];
                if (customer == null) continue;
                Console.WriteLine(customer);
            }
        }
    }
}
