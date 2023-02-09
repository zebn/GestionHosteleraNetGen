
using System;
// Definición clase ProductEN
namespace GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria
{
public partial class ProductEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo isActive
 */
private bool isActive;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo allergens
 */
private string allergens;



/**
 *	Atributo nutritionFacts
 */
private string nutritionFacts;



/**
 *	Atributo price
 */
private float price;



/**
 *	Atributo imageUrl
 */
private string imageUrl;



/**
 *	Atributo category
 */
private string category;



/**
 *	Atributo restaurant
 */
private GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN restaurant;



/**
 *	Atributo orders
 */
private GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN orders;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual bool IsActive {
        get { return isActive; } set { isActive = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual string Allergens {
        get { return allergens; } set { allergens = value;  }
}



public virtual string NutritionFacts {
        get { return nutritionFacts; } set { nutritionFacts = value;  }
}



public virtual float Price {
        get { return price; } set { price = value;  }
}



public virtual string ImageUrl {
        get { return imageUrl; } set { imageUrl = value;  }
}



public virtual string Category {
        get { return category; } set { category = value;  }
}



public virtual GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN Restaurant {
        get { return restaurant; } set { restaurant = value;  }
}



public virtual GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN Orders {
        get { return orders; } set { orders = value;  }
}





public ProductEN()
{
}



public ProductEN(int id, string name, bool isActive, string description, string allergens, string nutritionFacts, float price, string imageUrl, string category, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN restaurant, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN orders
                 )
{
        this.init (Id, name, isActive, description, allergens, nutritionFacts, price, imageUrl, category, restaurant, orders);
}


public ProductEN(ProductEN product)
{
        this.init (Id, product.Name, product.IsActive, product.Description, product.Allergens, product.NutritionFacts, product.Price, product.ImageUrl, product.Category, product.Restaurant, product.Orders);
}

private void init (int id
                   , string name, bool isActive, string description, string allergens, string nutritionFacts, float price, string imageUrl, string category, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.RestaurantEN restaurant, GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria.OrdersEN orders)
{
        this.Id = id;


        this.Name = name;

        this.IsActive = isActive;

        this.Description = description;

        this.Allergens = allergens;

        this.NutritionFacts = nutritionFacts;

        this.Price = price;

        this.ImageUrl = imageUrl;

        this.Category = category;

        this.Restaurant = restaurant;

        this.Orders = orders;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProductEN t = obj as ProductEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
