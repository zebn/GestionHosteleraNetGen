

using System;
using System.Text;
using System.Collections.Generic;

using GestionHosteleraNetGen.ApplicationCore.Exceptions;

using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
using GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria;


namespace GestionHosteleraNetGen.ApplicationCore.CEN.GestionHosteleria
{
/*
 *      Definition of the class ProductInvoiceDetailCEN
 *
 */
public partial class ProductInvoiceDetailCEN
{
private IProductInvoiceDetailRepository _IProductInvoiceDetailRepository;

public ProductInvoiceDetailCEN(IProductInvoiceDetailRepository _IProductInvoiceDetailRepository)
{
        this._IProductInvoiceDetailRepository = _IProductInvoiceDetailRepository;
}

public IProductInvoiceDetailRepository get_IProductInvoiceDetailRepository ()
{
        return this._IProductInvoiceDetailRepository;
}

public int GenerateInvoiceDetail (int p_id, float p_price, int p_invoice)
{
        ProductInvoiceDetailEN productInvoiceDetailEN = null;
        int oid;

        //Initialized ProductInvoiceDetailEN
        productInvoiceDetailEN = new ProductInvoiceDetailEN ();
        productInvoiceDetailEN.Id = p_id;

        productInvoiceDetailEN.Price = p_price;


        if (p_invoice != -1) {
                // El argumento p_invoice -> Property invoice es oid = false
                // Lista de oids id
                productInvoiceDetailEN.Invoice = new GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.InvoiceEN ();
                productInvoiceDetailEN.Invoice.Id = p_invoice;
        }

        //Call to ProductInvoiceDetailRepository

        oid = _IProductInvoiceDetailRepository.GenerateInvoiceDetail (productInvoiceDetailEN);
        return oid;
}
}
}
