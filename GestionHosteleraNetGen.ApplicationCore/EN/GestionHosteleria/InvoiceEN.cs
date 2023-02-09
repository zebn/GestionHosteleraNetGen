
using System;
// Definición clase InvoiceEN
namespace GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria
{
public partial class InvoiceEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo isPayed
 */
private bool isPayed;



/**
 *	Atributo attribute
 */
private float attribute;



/**
 *	Atributo orders
 */
private GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN orders;



/**
 *	Atributo productInvoiceDetail
 */
private System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.ProductInvoiceDetailEN> productInvoiceDetail;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual bool IsPayed {
        get { return isPayed; } set { isPayed = value;  }
}



public virtual float Attribute {
        get { return attribute; } set { attribute = value;  }
}



public virtual GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN Orders {
        get { return orders; } set { orders = value;  }
}



public virtual System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.ProductInvoiceDetailEN> ProductInvoiceDetail {
        get { return productInvoiceDetail; } set { productInvoiceDetail = value;  }
}





public InvoiceEN()
{
        productInvoiceDetail = new System.Collections.Generic.List<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.ProductInvoiceDetailEN>();
}



public InvoiceEN(int id, bool isPayed, float attribute, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN orders, System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.ProductInvoiceDetailEN> productInvoiceDetail
                 )
{
        this.init (Id, isPayed, attribute, orders, productInvoiceDetail);
}


public InvoiceEN(InvoiceEN invoice)
{
        this.init (Id, invoice.IsPayed, invoice.Attribute, invoice.Orders, invoice.ProductInvoiceDetail);
}

private void init (int id
                   , bool isPayed, float attribute, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN orders, System.Collections.Generic.IList<GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.ProductInvoiceDetailEN> productInvoiceDetail)
{
        this.Id = id;


        this.IsPayed = isPayed;

        this.Attribute = attribute;

        this.Orders = orders;

        this.ProductInvoiceDetail = productInvoiceDetail;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        InvoiceEN t = obj as InvoiceEN;
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
