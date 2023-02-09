
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;

namespace GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria
{
public partial interface ITablesRepository
{
TablesEN ReadOIDDefault (int id
                         );

void ModifyDefault (TablesEN tables);

System.Collections.Generic.IList<TablesEN> ReadAllDefault (int first, int size);
}
}
