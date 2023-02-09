
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
namespace GestionHosteleraNetGen.Infraestructure.EN.GestionHosteleria
{
public partial class ProductNH : ProductEN {
public ProductNH ()
{
}

public ProductNH (ProductEN dto)
{
        this.Id = dto.Id;


        this.Name = dto.Name;


        this.IsActive = dto.IsActive;


        this.Description = dto.Description;


        this.Allergens = dto.Allergens;


        this.NutritionFacts = dto.NutritionFacts;


        this.Price = dto.Price;


        this.ImageUrl = dto.ImageUrl;


        this.Category = dto.Category;
}
}
}
