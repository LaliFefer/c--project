using System;
using System.Collections.Generic;
using DalApi;

namespace Dal
{
    internal class Customer : ICustomer
    {
        public int Create(Customer customer)
        {
            foreach (var c in customers)
            {
                if (c?.Id== customer.Id)
                 throw new IdAlreadyExistsException("The ID " + id + " already exists.");
            }

            Customer cust = item with { Id = id };
            customers[StaticValue] = cust;
            return cust.id;
        }

        public Customer? Read(int id)
        {
           
            foreach (var c in customers)
            {
                if (c?.Id == Id)
                    return c;
             
            }
            throw new IdNotFoundException();
        }

        public List<Customer> ReadAll()
        {
            return new List<Customer>(customers.Values);
        }

        public void Update(Customer customer)
        {
            foreach (var c in customers)
            {
                if (customer.id==c?.id)
                {
                    Delete(c.Id);
                    Customers.Add(customer);
                }
            }
            throw new IdNotFoundException();
        }

        public void Delete(int id)
        {
            foreach (var c in customers)
            {
                if (customer.id == c?.id)
                {
                    Delete(c.Id);
                }
                throw new IdNotFoundException();
            }
           

            customers.Remove(id);
        }
    }
}