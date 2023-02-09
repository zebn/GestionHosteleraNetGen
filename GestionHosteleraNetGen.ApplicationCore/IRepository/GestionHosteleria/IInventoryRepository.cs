
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;

namespace GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria
{
public partial interface IInventoryRepository
{
InventoryEN ReadOIDDefault (int id
                            );

void ModifyDefault (InventoryEN inventory);

System.Collections.Generic.IList<InventoryEN> ReadAllDefault (int first, int size);



int AddItem (InventoryEN inventory);

void ModifyInventory (InventoryEN inventory);
}
}
