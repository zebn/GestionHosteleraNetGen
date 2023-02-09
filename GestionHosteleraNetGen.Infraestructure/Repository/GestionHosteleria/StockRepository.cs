
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
 * Clase Stock:
 *
 */

namespace GestionHosteleraNetGen.Infraestructure.Repository.GestionHosteleria
{
public partial class StockRepository : BasicRepository, IStockRepository
{
public StockRepository() : base ()
{
}


public StockRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public StockEN ReadOIDDefault (int id
                               )
{
        StockEN stockEN = null;

        try
        {
                SessionInitializeTransaction ();
                stockEN = (StockEN)session.Get (typeof(StockNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in StockRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return stockEN;
}

public System.Collections.Generic.IList<StockEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<StockEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(StockNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<StockEN>();
                        else
                                result = session.CreateCriteria (typeof(StockNH)).List<StockEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in StockRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (StockEN stock)
{
        try
        {
                SessionInitializeTransaction ();
                StockNH stockNH = (StockNH)session.Load (typeof(StockNH), stock.Id);

                stockNH.Name = stock.Name;


                stockNH.Quantity = stock.Quantity;


                session.Update (stockNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in StockRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int AddItem (StockEN stock)
{
        StockNH stockNH = new StockNH (stock);

        try
        {
                SessionInitializeTransaction ();

                session.Save (stockNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in StockRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return stockNH.Id;
}

public void ModifyStock (StockEN stock)
{
        try
        {
                SessionInitializeTransaction ();
                StockNH stockNH = (StockNH)session.Load (typeof(StockNH), stock.Id);

                stockNH.Name = stock.Name;


                stockNH.Quantity = stock.Quantity;

                session.Update (stockNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in StockRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
