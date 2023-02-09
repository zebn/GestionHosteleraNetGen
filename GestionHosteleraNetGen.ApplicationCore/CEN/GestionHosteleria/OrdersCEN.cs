

using System;
using System.Text;
using System.Collections.Generic;

using GestionHosteleraNetGen.ApplicationCore.Exceptions;

using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
using GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria;


namespace GestionHosteleraNetGen.ApplicationCore.CEN.GestionHosteleria
{
/*
 *      Definition of the class OrdersCEN
 *
 */
public partial class OrdersCEN
{
private IOrdersRepository _IOrdersRepository;

public OrdersCEN(IOrdersRepository _IOrdersRepository)
{
        this._IOrdersRepository = _IOrdersRepository;
}

public IOrdersRepository get_IOrdersRepository ()
{
        return this._IOrdersRepository;
}

public int CreateOrder (int p_id, Nullable<DateTime> p_creationTime, bool p_isActive)
{
        OrdersEN ordersEN = null;
        int oid;

        //Initialized OrdersEN
        ordersEN = new OrdersEN ();
        ordersEN.Id = p_id;

        ordersEN.CreationTime = p_creationTime;

        ordersEN.IsActive = p_isActive;

        //Call to OrdersRepository

        oid = _IOrdersRepository.CreateOrder (ordersEN);
        return oid;
}

public void ModifyOrder (int p_Orders_OID, Nullable<DateTime> p_creationTime, bool p_isActive)
{
        OrdersEN ordersEN = null;

        //Initialized OrdersEN
        ordersEN = new OrdersEN ();
        ordersEN.Id = p_Orders_OID;
        ordersEN.CreationTime = p_creationTime;
        ordersEN.IsActive = p_isActive;
        //Call to OrdersRepository

        _IOrdersRepository.ModifyOrder (ordersEN);
}
}
}
