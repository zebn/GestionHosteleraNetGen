
using System;
// Definición clase ProductInvoiceDetailEN
namespace GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria
{
public partial class ProductInvoiceDetailEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo price
 */
private float price;



/**
 *	Atributo invoice
 */
private GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.InvoiceEN invoice;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual float Price {
        get { return price; } set { price = value;  }
}



public virtual GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.InvoiceEN Invoice {
        get { return invoice; } set { invoice = value;  }
}





public ProductInvoiceDetailEN()
{
}



public ProductInvoiceDetailEN(int id, float price, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.InvoiceEN invoice
                              )
{
        this.init (Id, price, invoice);
}


public ProductInvoiceDetailEN(ProductInvoiceDetailEN productInvoiceDetail)
{
        this.init (Id, productInvoiceDetail.Price, productInvoiceDetail.Invoice);
}

private void init (int id
                   , float price, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.InvoiceEN invoice)
{
        this.Id = id;


        this.Price = price;

        this.Invoice = invoice;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProductInvoiceDetailEN t = obj as ProductInvoiceDetailEN;
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
