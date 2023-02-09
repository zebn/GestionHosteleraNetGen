
using System;
// Definición clase WaiterEN
namespace GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria
{
public partial class WaiterEN
{
/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo lastName
 */
private string lastName;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo password
 */
private string password;



/**
 *	Atributo restaurantId
 */
private int restaurantId;



/**
 *	Atributo isActive
 */
private bool isActive;



/**
 *	Atributo restaurant
 */
private GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN restaurant;



/**
 *	Atributo isMainWaiter
 */
private bool isMainWaiter;



/**
 *	Atributo isOwner
 */
private bool isOwner;






public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual string LastName {
        get { return lastName; } set { lastName = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Password {
        get { return password; } set { password = value;  }
}



public virtual int RestaurantId {
        get { return restaurantId; } set { restaurantId = value;  }
}



public virtual bool IsActive {
        get { return isActive; } set { isActive = value;  }
}



public virtual GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN Restaurant {
        get { return restaurant; } set { restaurant = value;  }
}



public virtual bool IsMainWaiter {
        get { return isMainWaiter; } set { isMainWaiter = value;  }
}



public virtual bool IsOwner {
        get { return isOwner; } set { isOwner = value;  }
}





public WaiterEN()
{
}



public WaiterEN(int id, string name, string lastName, string password, int restaurantId, bool isActive, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN restaurant, bool isMainWaiter, bool isOwner
                )
{
        this.init (Id, name, lastName, password, restaurantId, isActive, restaurant, isMainWaiter, isOwner);
}


public WaiterEN(WaiterEN waiter)
{
        this.init (Id, waiter.Name, waiter.LastName, waiter.Password, waiter.RestaurantId, waiter.IsActive, waiter.Restaurant, waiter.IsMainWaiter, waiter.IsOwner);
}

private void init (int id
                   , string name, string lastName, string password, int restaurantId, bool isActive, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN restaurant, bool isMainWaiter, bool isOwner)
{
        this.Id = id;


        this.Name = name;

        this.LastName = lastName;

        this.Password = password;

        this.RestaurantId = restaurantId;

        this.IsActive = isActive;

        this.Restaurant = restaurant;

        this.IsMainWaiter = isMainWaiter;

        this.IsOwner = isOwner;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        WaiterEN t = obj as WaiterEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
