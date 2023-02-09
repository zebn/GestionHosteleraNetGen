
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
namespace GestionHosteleraNetGen.Infraestructure.EN.GestionHosteleria
{
public partial class StockNH : StockEN {
public StockNH ()
{
}

public StockNH (StockEN dto)
{
        this.Id = dto.Id;


        this.Name = dto.Name;


        this.Quantity = dto.Quantity;
}
}
}
