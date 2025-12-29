using System;
using System.Runtime.InteropServices;

namespace Dal
{
        internal class Sale : ISale
        public int Create(Sale sale)
        {
            foreach (var s in sales)
            {
                if (s?.Id == sale.Id)
                throw new IdAlreadyExistsException("The ID " + id + " already exists.");
        }

            Customer sa = sale with { Id = id };
            sales[StaticValue] = sa;
            return sa.id;
        }

        public Sale? Read(int id)
        {

            foreach (var sale in sales)
            {
                if (sale?.Id == Id)
                    return sale;

            }
        throw new IdNotFoundException();
    }

        public List<Sale> ReadAll()
        {
            return new List<Sale>(sales.Values);
        }

        public void Update(Sale sale)
        {
            foreach (var c in sales)
            {
                if (sale.id == c?.id)
                {
                    Delete(c.Id);
                    sales.Add(sale);
                }
            }
        throw new IdNotFoundException();
    }

        public void Delete(int id)
        {
            foreach (var c in sales)
            {
                if (sale.id == c?.id)
                {
                    Delete(c.Id);
                }
            throw new IdNotFoundException();
        }


           sale.Remove(id);
        }
    }
}
