
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;

namespace GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria
{
public partial interface IInvoiceRepository
{
InvoiceEN ReadOIDDefault (int id
                          );

void ModifyDefault (InvoiceEN invoice);

System.Collections.Generic.IList<InvoiceEN> ReadAllDefault (int first, int size);



int GenerateInvoice (InvoiceEN invoice);

void ModifyInvoice (InvoiceEN invoice);
}
}
