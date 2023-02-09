

using System;
using System.Text;
using System.Collections.Generic;

using GestionHosteleraNetGen.ApplicationCore.Exceptions;

using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
using GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria;


namespace GestionHosteleraNetGen.ApplicationCore.CEN.GestionHosteleria
{
/*
 *      Definition of the class RestaurantCEN
 *
 */
public partial class RestaurantCEN
{
private IRestaurantRepository _IRestaurantRepository;

public RestaurantCEN(IRestaurantRepository _IRestaurantRepository)
{
        this._IRestaurantRepository = _IRestaurantRepository;
}

public IRestaurantRepository get_IRestaurantRepository ()
{
        return this._IRestaurantRepository;
}
}
}
