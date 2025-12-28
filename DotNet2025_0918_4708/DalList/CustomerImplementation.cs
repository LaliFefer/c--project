namespace Dal;
using DO;
using DalApi;

public class Customer : ICustomer
{
    public Class1()
    {
        int Create(Customer customer)
        {
            if (customer.IdNumber != null)
                throw new ArgumentException("existing ID");
        }
        Customer? Read(int id)
        {
            if (id != null)
                throw new ArgumentException("ID not found");
            return new Customer();
        }
        List<Customer> ReadAll()
        {
            return new List<Customer>();
        }
        void Update(Customer customer)
        {
            
        }
        void Delete(int id)
        {

        }
    }
}
