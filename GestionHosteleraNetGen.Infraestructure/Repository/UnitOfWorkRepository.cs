

using GestionHosteleraNetGen.ApplicationCore.IRepository.GestionHosteleria;
using GestionHosteleraNetGen.Infraestructure.Repository.GestionHosteleria;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionHosteleraNetGen.Infraestructure.Repository
{
public class UnitOfWorkRepository : GenericUnitOfWorkRepository
{
public UnitOfWorkRepository()
{
        this.productrepository = new ProductRepository ();
        this.ordersrepository = new OrdersRepository ();
        this.restaurantrepository = new RestaurantRepository ();
        this.waiterrepository = new WaiterRepository ();
        this.stockrepository = new StockRepository ();
        this.inventoryrepository = new InventoryRepository ();
        this.productinvoicedetailrepository = new ProductInvoiceDetailRepository ();
        this.tablesrepository = new TablesRepository ();
        this.invoicerepository = new InvoiceRepository ();
}
}
}

