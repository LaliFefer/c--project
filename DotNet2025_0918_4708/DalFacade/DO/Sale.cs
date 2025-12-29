
using System;

namespace DO;

public record Sale(int Id, int ProductId, int AmmontRequird, double TotalPrice ,bool IsClubMembers,DateTime StartSale,DateTime EndSale)
{
    public Sale() : this(12,123,14,12.5,true, new DateTime(2024, 2, 12), new DateTime(2024, 2, 21))
    {

    }
}
