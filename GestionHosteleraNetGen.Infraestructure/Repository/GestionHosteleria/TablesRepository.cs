
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
 * Clase Tables:
 *
 */

namespace GestionHosteleraNetGen.Infraestructure.Repository.GestionHosteleria
{
public partial class TablesRepository : BasicRepository, ITablesRepository
{
public TablesRepository() : base ()
{
}


public TablesRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public TablesEN ReadOIDDefault (int id
                                )
{
        TablesEN tablesEN = null;

        try
        {
                SessionInitializeTransaction ();
                tablesEN = (TablesEN)session.Get (typeof(TablesNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in TablesRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return tablesEN;
}

public System.Collections.Generic.IList<TablesEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<TablesEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(TablesNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<TablesEN>();
                        else
                                result = session.CreateCriteria (typeof(TablesNH)).List<TablesEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in TablesRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (TablesEN tables)
{
        try
        {
                SessionInitializeTransaction ();
                TablesNH tablesNH = (TablesNH)session.Load (typeof(TablesNH), tables.Id);

                tablesNH.IsAvailable = tables.IsAvailable;


                session.Update (tablesNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in TablesRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
