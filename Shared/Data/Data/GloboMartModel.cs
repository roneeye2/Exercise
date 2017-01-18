namespace GloboMart.Data
{
    using GloboMart.Framwork.Entity;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class GloboMartModel : DbContext
    {
        // Your context has been configured to use a 'GloboMartModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'GloboMart.Data.GloboMartModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'GloboMartModel' 
        // connection string in the application configuration file.
        public GloboMartModel()
            : base("name=GloboMartModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Product> Products { get; set; }
         public virtual DbSet<ProductCategory> ProductCategories { get; set; }
    }
}