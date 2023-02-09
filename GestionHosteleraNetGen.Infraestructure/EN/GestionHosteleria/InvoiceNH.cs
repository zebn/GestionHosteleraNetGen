
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
namespace GestionHosteleraNetGen.Infraestructure.EN.GestionHosteleria
{
public partial class InvoiceNH : InvoiceEN {
public InvoiceNH ()
{
}

public InvoiceNH (InvoiceEN dto)
{
        this.Id = dto.Id;


        this.IsPayed = dto.IsPayed;


        this.Attribute = dto.Attribute;
}
}
}
