
using System;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;

namespace GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria
{
public partial interface IProductRepository
{
ProductEN ReadOIDDefault (int id
                          );

void ModifyDefault (ProductEN product);

System.Collections.Generic.IList<ProductEN> ReadAllDefault (int first, int size);



int CreateProduct (ProductEN product);

void ModifyProduct (ProductEN product);


void DeleteProduct (int id
                    );
}
}
