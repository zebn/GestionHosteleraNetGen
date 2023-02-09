
using System;
using System.Text;
using System.Collections.Generic;
using GestionHosteleraNetGen.ApplicationCore.Exceptions;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
using GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria;
using GestionHosteleraNetGen.ApplicationCore.CEN.GestionHosteleria;



namespace GestionHosteleraNetGen.ApplicationCore.CP.GestionHosteleria
{
public partial class OrdersCP : GenericBasicCP
{
public OrdersCP(GenericSessionCP currentSession, GenericUnitOfWorkRepository unitRepo)
        : base (currentSession, unitRepo)
{
}
}
}
