
using System;
// Definición clase TablesEN
namespace GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria
{
public partial class TablesEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo isAvailable
 */
private bool isAvailable;



/**
 *	Atributo orders
 */
private System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN> orders;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual bool IsAvailable {
        get { return isAvailable; } set { isAvailable = value;  }
}



public virtual System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN> Orders {
        get { return orders; } set { orders = value;  }
}





public TablesEN()
{
        orders = new System.Collections.Generic.List<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN>();
}



public TablesEN(int id, bool isAvailable, System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN> orders
                )
{
        this.init (Id, isAvailable, orders);
}


public TablesEN(TablesEN tables)
{
        this.init (Id, tables.IsAvailable, tables.Orders);
}

private void init (int id
                   , bool isAvailable, System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN> orders)
{
        this.Id = id;


        this.IsAvailable = isAvailable;

        this.Orders = orders;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TablesEN t = obj as TablesEN;
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
