
using System;
// Definición clase InventoryEN
namespace GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria
{
public partial class InventoryEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo quantity
 */
private int quantity;



/**
 *	Atributo restaurant
 */
private GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN restaurant;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual int Quantity {
        get { return quantity; } set { quantity = value;  }
}



public virtual GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN Restaurant {
        get { return restaurant; } set { restaurant = value;  }
}





public InventoryEN()
{
}



public InventoryEN(int id, string name, int quantity, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN restaurant
                   )
{
        this.init (Id, name, quantity, restaurant);
}


public InventoryEN(InventoryEN inventory)
{
        this.init (Id, inventory.Name, inventory.Quantity, inventory.Restaurant);
}

private void init (int id
                   , string name, int quantity, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN restaurant)
{
        this.Id = id;


        this.Name = name;

        this.Quantity = quantity;

        this.Restaurant = restaurant;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        InventoryEN t = obj as InventoryEN;
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
