using System;
using System.Collections.Generic;
using DalApi;

namespace Dal
{
    internal class Product : IProduct
    {
        public int Create(Product product)
        {
            foreach (var c in products)
            {
                if (c?.Id == product.Id)
                    throw new IdAlreadyExistsException("The ID " + id + " already exists.");
            }

            Customer prod = item with { Id = id };
            products[StaticValue] = prod;
            return prod.id;
        }

        public Product? Read(int id)
        {

            foreach (var product in products)
            {
                if (product?.Id == Id)
                    return product;

            }
            throw new IdNotFoundException();
        }

        public List<Product> ReadAll()
        {
            return new List<Product>(products.Values);
        }

        public void Update(Product product)
        {
            foreach (var c in products)
            {
                if (product.id == c?.id)
                {
                    Delete(c.Id);
                    products.Add(product);
                }
            }
            throw new IdNotFoundException();
        }

        public void Delete(int id)
        {
            foreach (var c in products)
            {
                if (product.id == c?.id)
                {
                    Delete(c.Id);
                }
                throw new IdNotFoundException();
            }


            products.Remove(id);
        }
    }
}