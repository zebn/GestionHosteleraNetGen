
using System;
// Definición clase RestaurantEN
namespace GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria
{
public partial class RestaurantEN
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
 *	Atributo address
 */
private string address;



/**
 *	Atributo waiter
 */
private System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.WaiterEN> waiter;



/**
 *	Atributo stock
 */
private System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.StockEN> stock;



/**
 *	Atributo inventory
 */
private System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.InventoryEN> inventory;



/**
 *	Atributo product
 */
private System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.ProductEN> product;



/**
 *	Atributo orders
 */
private System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN> orders;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual string Address {
        get { return address; } set { address = value;  }
}



public virtual System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.WaiterEN> Waiter {
        get { return waiter; } set { waiter = value;  }
}



public virtual System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.StockEN> Stock {
        get { return stock; } set { stock = value;  }
}



public virtual System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.InventoryEN> Inventory {
        get { return inventory; } set { inventory = value;  }
}



public virtual System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.ProductEN> Product {
        get { return product; } set { product = value;  }
}



public virtual System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN> Orders {
        get { return orders; } set { orders = value;  }
}





public RestaurantEN()
{
        waiter = new System.Collections.Generic.List<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.WaiterEN>();
        stock = new System.Collections.Generic.List<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.StockEN>();
        inventory = new System.Collections.Generic.List<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.InventoryEN>();
        product = new System.Collections.Generic.List<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.ProductEN>();
        orders = new System.Collections.Generic.List<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN>();
}



public RestaurantEN(int id, string name, string address, System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.WaiterEN> waiter, System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.StockEN> stock, System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.InventoryEN> inventory, System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.ProductEN> product, System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN> orders
                    )
{
        this.init (Id, name, address, waiter, stock, inventory, product, orders);
}


public RestaurantEN(RestaurantEN restaurant)
{
        this.init (Id, restaurant.Name, restaurant.Address, restaurant.Waiter, restaurant.Stock, restaurant.Inventory, restaurant.Product, restaurant.Orders);
}

private void init (int id
                   , string name, string address, System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.WaiterEN> waiter, System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.StockEN> stock, System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.InventoryEN> inventory, System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.ProductEN> product, System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN> orders)
{
        this.Id = id;


        this.Name = name;

        this.Address = address;

        this.Waiter = waiter;

        this.Stock = stock;

        this.Inventory = inventory;

        this.Product = product;

        this.Orders = orders;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RestaurantEN t = obj as RestaurantEN;
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
