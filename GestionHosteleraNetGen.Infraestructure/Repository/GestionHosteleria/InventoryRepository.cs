
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
 * Clase Inventory:
 *
 */

namespace GestionHosteleraNetGen.Infraestructure.Repository.GestionHosteleria
{
public partial class InventoryRepository : BasicRepository, IInventoryRepository
{
public InventoryRepository() : base ()
{
}


public InventoryRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public InventoryEN ReadOIDDefault (int id
                                   )
{
        InventoryEN inventoryEN = null;

        try
        {
                SessionInitializeTransaction ();
                inventoryEN = (InventoryEN)session.Get (typeof(InventoryNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in InventoryRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return inventoryEN;
}

public System.Collections.Generic.IList<InventoryEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<InventoryEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(InventoryNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<InventoryEN>();
                        else
                                result = session.CreateCriteria (typeof(InventoryNH)).List<InventoryEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in InventoryRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (InventoryEN inventory)
{
        try
        {
                SessionInitializeTransaction ();
                InventoryNH inventoryNH = (InventoryNH)session.Load (typeof(InventoryNH), inventory.Id);

                inventoryNH.Name = inventory.Name;


                inventoryNH.Quantity = inventory.Quantity;


                session.Update (inventoryNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in InventoryRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int AddItem (InventoryEN inventory)
{
        InventoryNH inventoryNH = new InventoryNH (inventory);

        try
        {
                SessionInitializeTransaction ();

                session.Save (inventoryNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in InventoryRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return inventoryNH.Id;
}

public void ModifyInventory (InventoryEN inventory)
{
        try
        {
                SessionInitializeTransaction ();
                InventoryNH inventoryNH = (InventoryNH)session.Load (typeof(InventoryNH), inventory.Id);

                inventoryNH.Name = inventory.Name;


                inventoryNH.Quantity = inventory.Quantity;

                session.Update (inventoryNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in InventoryRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
