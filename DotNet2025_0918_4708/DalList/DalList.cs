using DalApi;

namespace Dal;

internal class DalList : IDal
{
    public ISale Sale => new SaleImplementation();
    public IProduct Product => new ProductImplementation();
    public ICustomer Customer => new CustomerImplementation();
}