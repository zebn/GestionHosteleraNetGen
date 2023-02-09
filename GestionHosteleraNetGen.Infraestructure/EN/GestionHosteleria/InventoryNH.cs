
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
namespace GestionHosteleraNetGen.Infraestructure.EN.GestionHosteleria
{
public partial class InventoryNH : InventoryEN {
public InventoryNH ()
{
}

public InventoryNH (InventoryEN dto)
{
        this.Id = dto.Id;


        this.Name = dto.Name;


        this.Quantity = dto.Quantity;
}
}
}
