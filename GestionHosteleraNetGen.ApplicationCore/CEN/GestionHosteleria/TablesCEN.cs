

using System;
using System.Text;
using System.Collections.Generic;

using GestionHosteleraNetGen.ApplicationCore.Exceptions;

using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
using GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria;


namespace GestionHosteleraNetGen.ApplicationCore.CEN.GestionHosteleria
{
/*
 *      Definition of the class TablesCEN
 *
 */
public partial class TablesCEN
{
private ITablesRepository _ITablesRepository;

public TablesCEN(ITablesRepository _ITablesRepository)
{
        this._ITablesRepository = _ITablesRepository;
}

public ITablesRepository get_ITablesRepository ()
{
        return this._ITablesRepository;
}
}
}
