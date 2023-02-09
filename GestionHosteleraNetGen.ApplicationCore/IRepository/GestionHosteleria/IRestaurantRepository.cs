
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;

namespace GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria
{
public partial interface IRestaurantRepository
{
RestaurantEN ReadOIDDefault (int id
                             );

void ModifyDefault (RestaurantEN restaurant);

System.Collections.Generic.IList<RestaurantEN> ReadAllDefault (int first, int size);
}
}
