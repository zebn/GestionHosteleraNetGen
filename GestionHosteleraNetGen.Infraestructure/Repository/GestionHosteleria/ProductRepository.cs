
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
 * Clase Product:
 *
 */

namespace GestionHosteleraNetGen.Infraestructure.Repository.GestionHosteleria
{
public partial class ProductRepository : BasicRepository, IProductRepository
{
public ProductRepository() : base ()
{
}


public ProductRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public ProductEN ReadOIDDefault (int id
                                 )
{
        ProductEN productEN = null;

        try
        {
                SessionInitializeTransaction ();
                productEN = (ProductEN)session.Get (typeof(ProductNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in ProductRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productEN;
}

public System.Collections.Generic.IList<ProductEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ProductEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ProductNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<ProductEN>();
                        else
                                result = session.CreateCriteria (typeof(ProductNH)).List<ProductEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in ProductRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ProductEN product)
{
        try
        {
                SessionInitializeTransaction ();
                ProductNH productNH = (ProductNH)session.Load (typeof(ProductNH), product.Id);

                productNH.Name = product.Name;


                productNH.IsActive = product.IsActive;


                productNH.Description = product.Description;


                productNH.Allergens = product.Allergens;


                productNH.NutritionFacts = product.NutritionFacts;


                productNH.Price = product.Price;


                productNH.ImageUrl = product.ImageUrl;


                productNH.Category = product.Category;



                session.Update (productNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in ProductRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CreateProduct (ProductEN product)
{
        ProductNH productNH = new ProductNH (product);

        try
        {
                SessionInitializeTransaction ();

                session.Save (productNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in ProductRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return productNH.Id;
}

public void ModifyProduct (ProductEN product)
{
        try
        {
                SessionInitializeTransaction ();
                ProductNH productNH = (ProductNH)session.Load (typeof(ProductNH), product.Id);

                productNH.Name = product.Name;


                productNH.IsActive = product.IsActive;


                productNH.Description = product.Description;


                productNH.Allergens = product.Allergens;


                productNH.NutritionFacts = product.NutritionFacts;


                productNH.Price = product.Price;


                productNH.ImageUrl = product.ImageUrl;


                productNH.Category = product.Category;

                session.Update (productNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in ProductRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void DeleteProduct (int id
                           )
{
        try
        {
                SessionInitializeTransaction ();
                ProductNH productNH = (ProductNH)session.Load (typeof(ProductNH), id);
                session.Delete (productNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in ProductRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
