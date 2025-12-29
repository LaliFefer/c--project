using System.Collections.Generic;

namespace Dal;

internal static class DataSource;
{
internal static List<Product?> Products = new List<Product>();
internal static List<Order?> Orders = new List<Order>();
internal static List<Customer?> Customers = new List<Customer>();

internal static class config
{
    internal const int initialId = 1000;
    static private statiValue=initialId;
    public static int StaticValue { get { return statiValue++; } }
}
}