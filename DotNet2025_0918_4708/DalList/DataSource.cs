using System.Collections.Generic;

namespace Dal;

internal static class DataSource;
{
internal static List<Product> Products { get; } = new()
{
    new Product(), // כל השדות יקבלו ערכי ברירת מחדל
    new Product(),
    new Product()
};
internal static List<Order> Orders { get; } = new()
{
    new Order(),
    new Order()
}
internal static List<Customer> Customers { get; } = new()
{
    new Customer(),
    new Customer()
};
internal static class config
{
    internal const int initialProductId = 1000;
    internal const int initialOrderId = 5000;
    internal const int initialCustomerId = 2000;
}
}