
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
 * Clase Restaurant:
 *
 */

namespace GestionHosteleraNetGen.Infraestructure.Repository.GestionHosteleria
{
public partial class RestaurantRepository : BasicRepository, IRestaurantRepository
{
public RestaurantRepository() : base ()
{
}


public RestaurantRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public RestaurantEN ReadOIDDefault (int id
                                    )
{
        RestaurantEN restaurantEN = null;

        try
        {
                SessionInitializeTransaction ();
                restaurantEN = (RestaurantEN)session.Get (typeof(RestaurantNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in RestaurantRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return restaurantEN;
}

public System.Collections.Generic.IList<RestaurantEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RestaurantEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RestaurantNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<RestaurantEN>();
                        else
                                result = session.CreateCriteria (typeof(RestaurantNH)).List<RestaurantEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in RestaurantRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RestaurantEN restaurant)
{
        try
        {
                SessionInitializeTransaction ();
                RestaurantNH restaurantNH = (RestaurantNH)session.Load (typeof(RestaurantNH), restaurant.Id);

                restaurantNH.Name = restaurant.Name;


                restaurantNH.Address = restaurant.Address;






                session.Update (restaurantNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is GestionHosteleraNetGen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new GestionHosteleraNetGen.ApplicationCore.Exceptions.DataLayerException ("Error in RestaurantRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
