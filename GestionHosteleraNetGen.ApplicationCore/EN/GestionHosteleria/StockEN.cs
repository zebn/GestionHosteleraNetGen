
using System;
// Definición clase StockEN
namespace GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria
{
public partial class StockEN
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





public StockEN()
{
}



public StockEN(int id, string name, int quantity, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN restaurant
               )
{
        this.init (Id, name, quantity, restaurant);
}


public StockEN(StockEN stock)
{
        this.init (Id, stock.Name, stock.Quantity, stock.Restaurant);
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
        StockEN t = obj as StockEN;
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
