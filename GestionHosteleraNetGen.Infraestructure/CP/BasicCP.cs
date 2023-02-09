

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using GestionHosteleraNetGen.Infraestructure.Repository.GestionHosteleria;
using GestionHosteleraNetGen.ApplicationCore.CP.GestionHosteleria;
using GestionHosteleraNetGen.Infraestructure.Repository;

namespace GestionHosteleraNetGen.Infraestructure.CP
{
public class BasicCPNHibernate : GenericBasicCP
{
protected ISession session;

protected ITransaction tx;


protected BasicCPNHibernate(SessionCPNHibernate sessionCP, UnitOfWorkRepository unitRepo) : base (sessionCP, unitRepo)
{
        session = (ISession)sessionCP.CurrentSession;
}
}
}

