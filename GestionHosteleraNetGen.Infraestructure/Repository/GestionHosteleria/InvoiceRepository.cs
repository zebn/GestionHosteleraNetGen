
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
 * Clase Invoice:
 *
 */

namespace GestionHosteleraNetGen.Infraestructure.Repository.GestionHosteleria
{
public partial class InvoiceRepository : BasicRepository, IInvoiceRepository
{
public InvoiceRepository() : base ()
{
}


public InvoiceRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public InvoiceEN ReadOIDDefault (int id
                                 )
{
        InvoiceEN invoiceEN = null;

        try
        {
                SessionInitializeTransaction ();
                invoiceEN = (InvoiceEN)session.Get (typeof(InvoiceNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in InvoiceRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return invoiceEN;
}

public System.Collections.Generic.IList<InvoiceEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<InvoiceEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(InvoiceNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<InvoiceEN>();
                        else
                                result = session.CreateCriteria (typeof(InvoiceNH)).List<InvoiceEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in InvoiceRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (InvoiceEN invoice)
{
        try
        {
                SessionInitializeTransaction ();
                InvoiceNH invoiceNH = (InvoiceNH)session.Load (typeof(InvoiceNH), invoice.Id);

                invoiceNH.IsPayed = invoice.IsPayed;


                invoiceNH.Attribute = invoice.Attribute;



                session.Update (invoiceNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in InvoiceRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int GenerateInvoice (InvoiceEN invoice)
{
        InvoiceNH invoiceNH = new InvoiceNH (invoice);

        try
        {
                SessionInitializeTransaction ();

                session.Save (invoiceNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in InvoiceRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return invoiceNH.Id;
}

public void ModifyInvoice (InvoiceEN invoice)
{
        try
        {
                SessionInitializeTransaction ();
                InvoiceNH invoiceNH = (InvoiceNH)session.Load (typeof(InvoiceNH), invoice.Id);

                invoiceNH.IsPayed = invoice.IsPayed;


                invoiceNH.Attribute = invoice.Attribute;

                session.Update (invoiceNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in InvoiceRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
