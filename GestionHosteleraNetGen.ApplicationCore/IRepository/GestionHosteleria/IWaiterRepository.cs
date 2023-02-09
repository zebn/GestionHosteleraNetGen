
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;

namespace GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria
{
public partial interface IWaiterRepository
{
WaiterEN ReadOIDDefault (int id
                         );

void ModifyDefault (WaiterEN waiter);

System.Collections.Generic.IList<WaiterEN> ReadAllDefault (int first, int size);




int Operation (WaiterEN waiter);
}
}
