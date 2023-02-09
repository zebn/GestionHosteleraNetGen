
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
 * Clase Orders:
 *
 */

namespace GestionHosteleraNetGen.Infraestructure.Repository.GestionHosteleria
{
public partial class OrdersRepository : BasicRepository, IOrdersRepository
{
public OrdersRepository() : base ()
{
}


public OrdersRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public OrdersEN ReadOIDDefault (int id
                                )
{
        OrdersEN ordersEN = null;

        try
        {
                SessionInitializeTransaction ();
                ordersEN = (OrdersEN)session.Get (typeof(OrdersNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in OrdersRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ordersEN;
}

public System.Collections.Generic.IList<OrdersEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<OrdersEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(OrdersNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<OrdersEN>();
                        else
                                result = session.CreateCriteria (typeof(OrdersNH)).List<OrdersEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in OrdersRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (OrdersEN orders)
{
        try
        {
                SessionInitializeTransaction ();
                OrdersNH ordersNH = (OrdersNH)session.Load (typeof(OrdersNH), orders.Id);

                ordersNH.CreationTime = orders.CreationTime;


                ordersNH.IsActive = orders.IsActive;





                session.Update (ordersNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in OrdersRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CreateOrder (OrdersEN orders)
{
        OrdersNH ordersNH = new OrdersNH (orders);

        try
        {
                SessionInitializeTransaction ();

                session.Save (ordersNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in OrdersRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ordersNH.Id;
}

public void ModifyOrder (OrdersEN orders)
{
        try
        {
                SessionInitializeTransaction ();
                OrdersNH ordersNH = (OrdersNH)session.Load (typeof(OrdersNH), orders.Id);

                ordersNH.CreationTime = orders.CreationTime;


                ordersNH.IsActive = orders.IsActive;

                session.Update (ordersNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in OrdersRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
