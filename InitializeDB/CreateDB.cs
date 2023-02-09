
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using GestionHosteleraNetGen.ApplicationCore.EN.GestionHosteleria;
using GestionHosteleraNetGen.ApplicationCore.CEN.GestionHosteleria;
using GestionHosteleraNetGen.Infraestructure.Repository.GestionHosteleria;
using GestionHosteleraNetGen.ApplicationCore.Exceptions;
using GestionHosteleraNetGen.ApplicationCore.CP.GestionHosteleria;
using GestionHosteleraNetGen.Infraestructure.Repository;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local); database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        try
        {
                ProductRepository productrepository = new ProductRepository ();
                ProductCEN productcen = new ProductCEN (productrepository);
                OrdersRepository ordersrepository = new OrdersRepository ();
                OrdersCEN orderscen = new OrdersCEN (ordersrepository);
                RestaurantRepository restaurantrepository = new RestaurantRepository ();
                RestaurantCEN restaurantcen = new RestaurantCEN (restaurantrepository);
                WaiterRepository waiterrepository = new WaiterRepository ();
                WaiterCEN waitercen = new WaiterCEN (waiterrepository);
                StockRepository stockrepository = new StockRepository ();
                StockCEN stockcen = new StockCEN (stockrepository);
                InventoryRepository inventoryrepository = new InventoryRepository ();
                InventoryCEN inventorycen = new InventoryCEN (inventoryrepository);
                ProductInvoiceDetailRepository productinvoicedetailrepository = new ProductInvoiceDetailRepository ();
                ProductInvoiceDetailCEN productinvoicedetailcen = new ProductInvoiceDetailCEN (productinvoicedetailrepository);
                TablesRepository tablesrepository = new TablesRepository ();
                TablesCEN tablescen = new TablesCEN (tablesrepository);
                InvoiceRepository invoicerepository = new InvoiceRepository ();
                InvoiceCEN invoicecen = new InvoiceCEN (invoicerepository);


                /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/

                // You must write the initialisation of the entities inside the PROTECTED comments.
                // IMPORTANT:please do not delete them.

                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
