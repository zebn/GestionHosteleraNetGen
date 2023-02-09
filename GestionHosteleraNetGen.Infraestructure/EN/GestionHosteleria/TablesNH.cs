
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
namespace GestionHosteleraNetGen.Infraestructure.EN.GestionHosteleria
{
public partial class TablesNH : TablesEN {
public TablesNH ()
{
}

public TablesNH (TablesEN dto)
{
        this.Id = dto.Id;


        this.IsAvailable = dto.IsAvailable;
}
}
}
