
using System;
// Definición clase OrdersEN
namespace GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria
{
public partial class OrdersEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo creationTime
 */
private Nullable<DateTime> creationTime;



/**
 *	Atributo isActive
 */
private bool isActive;



/**
 *	Atributo tables
 */
private GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.TablesEN tables;



/**
 *	Atributo restaurant
 */
private GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN restaurant;



/**
 *	Atributo invoice
 */
private GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.InvoiceEN invoice;



/**
 *	Atributo product
 */
private GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.ProductEN product;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> CreationTime {
        get { return creationTime; } set { creationTime = value;  }
}



public virtual bool IsActive {
        get { return isActive; } set { isActive = value;  }
}



public virtual GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.TablesEN Tables {
        get { return tables; } set { tables = value;  }
}



public virtual GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN Restaurant {
        get { return restaurant; } set { restaurant = value;  }
}



public virtual GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.InvoiceEN Invoice {
        get { return invoice; } set { invoice = value;  }
}



public virtual GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.ProductEN Product {
        get { return product; } set { product = value;  }
}





public OrdersEN()
{
}



public OrdersEN(int id, Nullable<DateTime> creationTime, bool isActive, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.TablesEN tables, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN restaurant, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.InvoiceEN invoice, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.ProductEN product
                )
{
        this.init (Id, creationTime, isActive, tables, restaurant, invoice, product);
}


public OrdersEN(OrdersEN orders)
{
        this.init (Id, orders.CreationTime, orders.IsActive, orders.Tables, orders.Restaurant, orders.Invoice, orders.Product);
}

private void init (int id
                   , Nullable<DateTime> creationTime, bool isActive, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.TablesEN tables, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN restaurant, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.InvoiceEN invoice, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.ProductEN product)
{
        this.Id = id;


        this.CreationTime = creationTime;

        this.IsActive = isActive;

        this.Tables = tables;

        this.Restaurant = restaurant;

        this.Invoice = invoice;

        this.Product = product;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        OrdersEN t = obj as OrdersEN;
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
