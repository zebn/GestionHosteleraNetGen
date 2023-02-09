
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
namespace GestionHosteleraNetGen.Infraestructure.EN.GestionHosteleria
{
public partial class WaiterNH : WaiterEN {
public WaiterNH ()
{
}

public WaiterNH (WaiterEN dto)
{
        this.Name = dto.Name;


        this.LastName = dto.LastName;


        this.Id = dto.Id;


        this.Password = dto.Password;


        this.RestaurantId = dto.RestaurantId;


        this.IsActive = dto.IsActive;


        this.IsMainWaiter = dto.IsMainWaiter;


        this.IsOwner = dto.IsOwner;
}
}
}
