

using System;
using System.Text;
using System.Collections.Generic;

using GestionHosteleraNetGen.ApplicationCore.Exceptions;

using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
using GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria;


namespace GestionHosteleraNetGen.ApplicationCore.CEN.GestionHosteleria
{
/*
 *      Definition of the class InventoryCEN
 *
 */
public partial class InventoryCEN
{
private IInventoryRepository _IInventoryRepository;

public InventoryCEN(IInventoryRepository _IInventoryRepository)
{
        this._IInventoryRepository = _IInventoryRepository;
}

public IInventoryRepository get_IInventoryRepository ()
{
        return this._IInventoryRepository;
}

public int AddItem (int p_id, string p_name, int p_quantity)
{
        InventoryEN inventoryEN = null;
        int oid;

        //Initialized InventoryEN
        inventoryEN = new InventoryEN ();
        inventoryEN.Id = p_id;

        inventoryEN.Name = p_name;

        inventoryEN.Quantity = p_quantity;

        //Call to InventoryRepository

        oid = _IInventoryRepository.AddItem (inventoryEN);
        return oid;
}

public void ModifyInventory (int p_Inventory_OID, string p_name, int p_quantity)
{
        InventoryEN inventoryEN = null;

        //Initialized InventoryEN
        inventoryEN = new InventoryEN ();
        inventoryEN.Id = p_Inventory_OID;
        inventoryEN.Name = p_name;
        inventoryEN.Quantity = p_quantity;
        //Call to InventoryRepository

        _IInventoryRepository.ModifyInventory (inventoryEN);
}
}
}
