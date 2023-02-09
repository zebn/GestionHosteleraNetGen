
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;

namespace GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria
{
public partial interface IOrdersRepository
{
OrdersEN ReadOIDDefault (int id
                         );

void ModifyDefault (OrdersEN orders);

System.Collections.Generic.IList<OrdersEN> ReadAllDefault (int first, int size);



int CreateOrder (OrdersEN orders);

void ModifyOrder (OrdersEN orders);
}
}
