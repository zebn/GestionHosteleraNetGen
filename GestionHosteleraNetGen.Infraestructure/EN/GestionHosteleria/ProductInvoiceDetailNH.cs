
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
namespace GestionHosteleraNetGen.Infraestructure.EN.GestionHosteleria
{
public partial class ProductInvoiceDetailNH : ProductInvoiceDetailEN {
public ProductInvoiceDetailNH ()
{
}

public ProductInvoiceDetailNH (ProductInvoiceDetailEN dto)
{
        this.Id = dto.Id;


        this.Price = dto.Price;
}
}
}
