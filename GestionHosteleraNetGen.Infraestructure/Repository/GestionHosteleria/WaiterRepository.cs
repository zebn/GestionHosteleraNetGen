
using System;
using System.Text;
using GestionHosteleraNetGen.ApplicationCore.CEN.GestionHosteleria;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
using GestionHosteleraNetGen.ApplicationCore.Exceptions;
using GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria;
using GestionHosteleraNetGen.ApplicationCore.CP.GestionHosteleria;
using GestionHosteleraNetGen.Infraestructure.EN.GestionHosteleria;


/*
 * Clase Waiter:
 *
 */

namespace GestionHosteleraNetGen.Infraestructure.Repository.GestionHosteleria
{
public partial class WaiterRepository : BasicRepository, IWaiterRepository
{
public WaiterRepository() : base ()
{
}


public WaiterRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public WaiterEN ReadOIDDefault (int id
                                )
{
        WaiterEN waiterEN = null;

        try
        {
                SessionInitializeTransaction ();
                waiterEN = (WaiterEN)session.Get (typeof(WaiterNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in WaiterRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return waiterEN;
}

public System.Collections.Generic.IList<WaiterEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<WaiterEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(WaiterNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<WaiterEN>();
                        else
                                result = session.CreateCriteria (typeof(WaiterNH)).List<WaiterEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in WaiterRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (WaiterEN waiter)
{
        try
        {
                SessionInitializeTransaction ();
                WaiterNH waiterNH = (WaiterNH)session.Load (typeof(WaiterNH), waiter.Id);

                waiterNH.Name = waiter.Name;


                waiterNH.LastName = waiter.LastName;


                waiterNH.Password = waiter.Password;


                waiterNH.RestaurantId = waiter.RestaurantId;


                waiterNH.IsActive = waiter.IsActive;



                waiterNH.IsMainWaiter = waiter.IsMainWaiter;


                waiterNH.IsOwner = waiter.IsOwner;

                session.Update (waiterNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in WaiterRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Operation (WaiterEN waiter)
{
        WaiterNH waiterNH = new WaiterNH (waiter);

        try
        {
                SessionInitializeTransaction ();

                session.Save (waiterNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in WaiterRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return waiterNH.Id;
}
}
}
