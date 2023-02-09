

using System;
using System.Collections.Generic;
using GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria;

namespace GestionHosteleraNetGen.ApplicationCore.CP.GestionHosteleria
{
public abstract class GenericBasicCP
{
protected GenericSessionCP CPSession;
protected GenericUnitOfWorkRepository unitRepo;
protected GenericBasicCP (GenericSessionCP currentSession, GenericUnitOfWorkRepository unitRepo)
{
        this.CPSession = currentSession;
        this.unitRepo = unitRepo;
}
}
}

