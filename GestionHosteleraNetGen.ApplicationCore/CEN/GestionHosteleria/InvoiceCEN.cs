

using System;
using System.Text;
using System.Collections.Generic;

using GestionHosteleraNetGen.ApplicationCore.Exceptions;

using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
using GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria;


namespace GestionHosteleraNetGen.ApplicationCore.CEN.GestionHosteleria
{
/*
 *      Definition of the class InvoiceCEN
 *
 */
public partial class InvoiceCEN
{
private IInvoiceRepository _IInvoiceRepository;

public InvoiceCEN(IInvoiceRepository _IInvoiceRepository)
{
        this._IInvoiceRepository = _IInvoiceRepository;
}

public IInvoiceRepository get_IInvoiceRepository ()
{
        return this._IInvoiceRepository;
}

public int GenerateInvoice (int p_id, bool p_isPayed, float p_attribute)
{
        InvoiceEN invoiceEN = null;
        int oid;

        //Initialized InvoiceEN
        invoiceEN = new InvoiceEN ();
        invoiceEN.Id = p_id;

        invoiceEN.IsPayed = p_isPayed;

        invoiceEN.Attribute = p_attribute;

        //Call to InvoiceRepository

        oid = _IInvoiceRepository.GenerateInvoice (invoiceEN);
        return oid;
}

public void ModifyInvoice (int p_Invoice_OID, bool p_isPayed, float p_attribute)
{
        InvoiceEN invoiceEN = null;

        //Initialized InvoiceEN
        invoiceEN = new InvoiceEN ();
        invoiceEN.Id = p_Invoice_OID;
        invoiceEN.IsPayed = p_isPayed;
        invoiceEN.Attribute = p_attribute;
        //Call to InvoiceRepository

        _IInvoiceRepository.ModifyInvoice (invoiceEN);
}
}
}
