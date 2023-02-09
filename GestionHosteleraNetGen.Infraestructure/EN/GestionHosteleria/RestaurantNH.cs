
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
namespace GestionHosteleraNetGen.Infraestructure.EN.GestionHosteleria
{
public partial class RestaurantNH : RestaurantEN {
public RestaurantNH ()
{
}

public RestaurantNH (RestaurantEN dto)
{
        this.Id = dto.Id;


        this.Name = dto.Name;


        this.Address = dto.Address;
}
}
}
