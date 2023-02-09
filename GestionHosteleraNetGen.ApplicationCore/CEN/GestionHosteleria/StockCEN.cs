

using System;
using System.Text;
using System.Collections.Generic;

using GestionHosteleraNetGen.ApplicationCore.Exceptions;

using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
using GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria;


namespace GestionHosteleraNetGen.ApplicationCore.CEN.GestionHosteleria
{
/*
 *      Definition of the class StockCEN
 *
 */
public partial class StockCEN
{
private IStockRepository _IStockRepository;

public StockCEN(IStockRepository _IStockRepository)
{
        this._IStockRepository = _IStockRepository;
}

public IStockRepository get_IStockRepository ()
{
        return this._IStockRepository;
}

public int AddItem (int p_id, string p_name, int p_quantity)
{
        StockEN stockEN = null;
        int oid;

        //Initialized StockEN
        stockEN = new StockEN ();
        stockEN.Id = p_id;

        stockEN.Name = p_name;

        stockEN.Quantity = p_quantity;

        //Call to StockRepository

        oid = _IStockRepository.AddItem (stockEN);
        return oid;
}

public void ModifyStock (int p_Stock_OID, string p_name, int p_quantity)
{
        StockEN stockEN = null;

        //Initialized StockEN
        stockEN = new StockEN ();
        stockEN.Id = p_Stock_OID;
        stockEN.Name = p_name;
        stockEN.Quantity = p_quantity;
        //Call to StockRepository

        _IStockRepository.ModifyStock (stockEN);
}
}
}
