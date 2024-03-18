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
            data = new Customer[capacity];
        }

        public void Insert(Customer customer)
        {
            if (IsFull()) return;
            data[Count] = customer;
            Count++;
        }

        public void Insert(string firstName, string lastName, string phoneNumber)
        {
            Insert(new Customer(firstName, lastName, phoneNumber));
        }

        public bool Delete(string firstName, 
            string lastName)
        {
            if (IsEmpty()) return false;
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
            // Index is the element to remove
            // Shift all elements after it to the left
            for (; index < Count; index++)
            {
                data[index] = data[index + 1];
            }
            Count--;
            return true;
        }

        public string Find(string firstName, 
            string lastName)
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

        public bool IsFull()
        {
            return Count == Capacity;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public void Display()
        {
            foreach (Customer customer in data) {
                Console.WriteLine(customer);
            }
        }
    }
}
