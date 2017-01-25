using GloboMart.Framwork.Entity;
using GloboMart.Framwork.Interface;
using GloboMart.Framwork.Interface.Data;
using GloboMart.Framwork.Interface.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Data
{
    [Export(typeof(IModule))]
    public class ModuleInit : IModule
    {
        public void Initialize(IModuleRegistrar registrar)
        {
            registrar.RegisterType<IProductRepo, ProductRepository>();
            registrar.RegisterType<IProductCategoryRepo, ProductCategoryRepository>();
            registrar.RegisterType<IProduct, Product>();
            registrar.RegisterType<IProductCategory, ProductCategory>();
            registrar.RegisterType<IProductPriceSchedule, ProductPriceSchedule>();
            registrar.RegisterType<IDbEntries, DatabaseDefaultEntries>();
        }
    }
}
