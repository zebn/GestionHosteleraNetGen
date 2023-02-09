
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
 * Clase ProductInvoiceDetail:
 *
 */

namespace GestionHosteleraNetGen.Infraestructure.Repository.GestionHosteleria
{
public partial class ProductInvoiceDetailRepository : BasicRepository, IProductInvoiceDetailRepository
{
public ProductInvoiceDetailRepository() : base ()
{
}


public ProductInvoiceDetailRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public ProductInvoiceDetailEN ReadOIDDefault (int id
                                              )
{
        ProductInvoiceDetailEN productInvoiceDetailEN = null;

        try
        {
                SessionInitializeTransaction ();
                productInvoiceDetailEN = (ProductInvoiceDetailEN)session.Get (typeof(ProductInvoiceDetailNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in ProductInvoiceDetailRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productInvoiceDetailEN;
}

public System.Collections.Generic.IList<ProductInvoiceDetailEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ProductInvoiceDetailEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ProductInvoiceDetailNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<ProductInvoiceDetailEN>();
                        else
                                result = session.CreateCriteria (typeof(ProductInvoiceDetailNH)).List<ProductInvoiceDetailEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in ProductInvoiceDetailRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ProductInvoiceDetailEN productInvoiceDetail)
{
        try
        {
                SessionInitializeTransaction ();
                ProductInvoiceDetailNH productInvoiceDetailNH = (ProductInvoiceDetailNH)session.Load (typeof(ProductInvoiceDetailNH), productInvoiceDetail.Id);

                productInvoiceDetailNH.Price = productInvoiceDetail.Price;


                session.Update (productInvoiceDetailNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in ProductInvoiceDetailRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int GenerateInvoiceDetail (ProductInvoiceDetailEN productInvoiceDetail)
{
        ProductInvoiceDetailNH productInvoiceDetailNH = new ProductInvoiceDetailNH (productInvoiceDetail);

        try
        {
                SessionInitializeTransaction ();
                if (productInvoiceDetail.Invoice != null) {
                        // Argumento OID y no colección.
                        productInvoiceDetailNH
                        .Invoice = (GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.InvoiceEN)session.Load (typeof(GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.InvoiceEN), productInvoiceDetail.Invoice.Id);

                        productInvoiceDetail.Invoice.ProductInvoiceDetail
                        .Add (productInvoiceDetail);
                }

                session.Save (productInvoiceDetailNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in ProductInvoiceDetailRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productInvoiceDetailNH.Id;
}
}
}
