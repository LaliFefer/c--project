// See https://aka.ms/new-console-template for more information
using System.Data.SqlTypes;

Console.WriteLine("Hello, World!");
private static IDal s_dal = new DalList();

try
{
    Initialization.initialize(s_dal);
}
catch(IdNotFoundException e)
{
    Console.WriteLine($"Caught an exception: {e.Message}");
}
catch (IdAlreadyExistsException e)
{
    Console.WriteLine($"Caught an exception: {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"Caught an exception: {e.Message}");
}

Console.WriteLine("Insert 1 for customer, 2 for product, 3 for sale:");
string input = Console.ReadLine(); 
int choice = int.Parse(input); 
switch (choice)
{
    case 1:
        customerDal = new CustomerImplementation();
        break;
    case 2:
        productDal = new ProductImplementation();
        break;
    case 3:
        saleDal = new SaleImplementation();
        break;
}

Console.WriteLine("Insert 1 for create, 2 for delete, 3 for update");
string input = Console.ReadLine();
int FuncChoice = int.Parse(input); 
switch (FuncChoice)
{
    case 1:
        s_dal.create();
        break;
    case 2:
        s_dal.delete();
        break;
    case 3:
        s_dal.update();
        break;
    default:
        Console.WriteLine("Invalid selection.");
        break;
}