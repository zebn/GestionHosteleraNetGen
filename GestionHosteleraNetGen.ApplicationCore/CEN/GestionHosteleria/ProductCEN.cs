

using System;
using System.Text;
using System.Collections.Generic;

using GestionHosteleraNetGen.ApplicationCore.Exceptions;

using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
using GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria;


namespace GestionHosteleraNetGen.ApplicationCore.CEN.GestionHosteleria
{
/*
 *      Definition of the class ProductCEN
 *
 */
public partial class ProductCEN
{
private IProductRepository _IProductRepository;

public ProductCEN(IProductRepository _IProductRepository)
{
        this._IProductRepository = _IProductRepository;
}

public IProductRepository get_IProductRepository ()
{
        return this._IProductRepository;
}

public int CreateProduct (int p_id, string p_name, bool p_isActive, string p_description, string p_allergens, string p_nutritionFacts, float p_price, string p_imageUrl, string p_category)
{
        ProductEN productEN = null;
        int oid;

        //Initialized ProductEN
        productEN = new ProductEN ();
        productEN.Id = p_id;

        productEN.Name = p_name;

        productEN.IsActive = p_isActive;

        productEN.Description = p_description;

        productEN.Allergens = p_allergens;

        productEN.NutritionFacts = p_nutritionFacts;

        productEN.Price = p_price;

        productEN.ImageUrl = p_imageUrl;

        productEN.Category = p_category;

        //Call to ProductRepository

        oid = _IProductRepository.CreateProduct (productEN);
        return oid;
}

public void ModifyProduct (int p_Product_OID, string p_name, bool p_isActive, string p_description, string p_allergens, string p_nutritionFacts, float p_price, string p_imageUrl, string p_category)
{
        ProductEN productEN = null;

        //Initialized ProductEN
        productEN = new ProductEN ();
        productEN.Id = p_Product_OID;
        productEN.Name = p_name;
        productEN.IsActive = p_isActive;
        productEN.Description = p_description;
        productEN.Allergens = p_allergens;
        productEN.NutritionFacts = p_nutritionFacts;
        productEN.Price = p_price;
        productEN.ImageUrl = p_imageUrl;
        productEN.Category = p_category;
        //Call to ProductRepository

        _IProductRepository.ModifyProduct (productEN);
}

public void DeleteProduct (int id
                           )
{
        _IProductRepository.DeleteProduct (id);
}
}
}
