
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
namespace GestionHosteleraNetGen.Infraestructure.EN.GestionHosteleria
{
public partial class OrdersNH : OrdersEN {
public OrdersNH ()
{
}

public OrdersNH (OrdersEN dto)
{
        this.Id = dto.Id;


        this.CreationTime = dto.CreationTime;


        this.IsActive = dto.IsActive;
}
}
}
