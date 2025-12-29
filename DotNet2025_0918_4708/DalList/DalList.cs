using System;
using DalApi;

public class DalList
{
	public ISale Sale => SaleImplementation();
    public IProduct Product => ProductImplementation();
    public ICustomer Customer => CustomerImplementation();
    
}
