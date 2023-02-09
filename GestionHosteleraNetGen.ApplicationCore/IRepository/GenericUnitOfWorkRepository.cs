
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria
{
public abstract class GenericUnitOfWorkRepository
{
public IProductRepository productrepository {
        set; get;
}
public IOrdersRepository ordersrepository {
        set; get;
}
public IRestaurantRepository restaurantrepository {
        set; get;
}
public IWaiterRepository waiterrepository {
        set; get;
}
public IStockRepository stockrepository {
        set; get;
}
public IInventoryRepository inventoryrepository {
        set; get;
}
public IProductInvoiceDetailRepository productinvoicedetailrepository {
        set; get;
}
public ITablesRepository tablesrepository {
        set; get;
}
public IInvoiceRepository invoicerepository {
        set; get;
}
}
}
