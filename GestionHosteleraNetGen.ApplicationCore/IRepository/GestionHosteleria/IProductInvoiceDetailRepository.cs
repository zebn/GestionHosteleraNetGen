
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;

namespace GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria
{
public partial interface IProductInvoiceDetailRepository
{
ProductInvoiceDetailEN ReadOIDDefault (int id
                                       );

void ModifyDefault (ProductInvoiceDetailEN productInvoiceDetail);

System.Collections.Generic.IList<ProductInvoiceDetailEN> ReadAllDefault (int first, int size);



int GenerateInvoiceDetail (ProductInvoiceDetailEN productInvoiceDetail);
}
}
