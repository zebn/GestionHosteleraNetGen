

using System;
using System.Text;
using System.Collections.Generic;

using GestionHosteleraNetGen.ApplicationCore.Exceptions;

using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
using GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria;


namespace GestionHosteleraNetGen.ApplicationCore.CEN.GestionHosteleria
{
/*
 *      Definition of the class WaiterCEN
 *
 */
public partial class WaiterCEN
{
private IWaiterRepository _IWaiterRepository;

public WaiterCEN(IWaiterRepository _IWaiterRepository)
{
        this._IWaiterRepository = _IWaiterRepository;
}

public IWaiterRepository get_IWaiterRepository ()
{
        return this._IWaiterRepository;
}

public int Operation (string p_name, string p_lastName, int p_id, string p_password, int p_restaurantId, bool p_isActive, bool p_isMainWaiter, bool p_isOwner)
{
        WaiterEN waiterEN = null;
        int oid;

        //Initialized WaiterEN
        waiterEN = new WaiterEN ();
        waiterEN.Name = p_name;

        waiterEN.LastName = p_lastName;

        waiterEN.Id = p_id;

        waiterEN.Password = p_password;

        waiterEN.RestaurantId = p_restaurantId;

        waiterEN.IsActive = p_isActive;

        waiterEN.IsMainWaiter = p_isMainWaiter;

        waiterEN.IsOwner = p_isOwner;

        //Call to WaiterRepository

        oid = _IWaiterRepository.Operation (waiterEN);
        return oid;
}
}
}
