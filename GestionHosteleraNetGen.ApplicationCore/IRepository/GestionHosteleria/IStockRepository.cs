
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;

namespace GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria
{
public partial interface IStockRepository
{
StockEN ReadOIDDefault (int id
                        );

void ModifyDefault (StockEN stock);

System.Collections.Generic.IList<StockEN> ReadAllDefault (int first, int size);



int AddItem (StockEN stock);

void ModifyStock (StockEN stock);
}
}
