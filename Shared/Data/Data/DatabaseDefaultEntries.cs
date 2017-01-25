using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using GloboMart.Framwork.Interface.Entity;
using GloboMart.Framwork.Interface.Enum;
using GloboMart.Framwork.Interface.Data;
using GloboMart.Framwork.Interface;
using GloboMart.Framwork.Entity;

namespace GloboMart.Data
{
    internal class DatabaseDefaultEntries : IDbEntries
    {
        private GloboMartContext CurrentDbContext;
        public DatabaseDefaultEntries(GloboMartContext dbContext)
        {
            CurrentDbContext = dbContext;
        }
        public void Execute()
        {
            FillCategories();
            //var category = FillCategories();
            //FillProduct(category);
        }

        private IProductCategory FillCategories()
        {
            new ProductCategoryRepository(CurrentDbContext).Create(new ProductCategory
            {
                Name = eProductCategory.Cloths,
                Discription = "",
            });

            new ProductCategoryRepository(CurrentDbContext).Create(new ProductCategory
            {
                Name = eProductCategory.Mobile,
                Discription = "",
            });

            new ProductCategoryRepository(CurrentDbContext).Create(new ProductCategory
            {
                Name = eProductCategory.PC,
                Discription = "",
            });

            new ProductCategoryRepository(CurrentDbContext).Create(new ProductCategory
            {
                Name = eProductCategory.Footware,
                Discription = "",
            });

            return new ProductCategoryRepository(CurrentDbContext).Create(new ProductCategory
            {
                Name = eProductCategory.Vehicle,
                Discription = "",
            });
        }

        //private static void FillProduct(IProductCategory category)
        //{
        //    var product = _this.ProductModel;
        //    product.Name = "IPhone";
        //    product.ProductCategory = category;
        //    _this.ProductRepo.Create(product);

        //    product.Name = "Samsung";
        //    product.ProductCategory = category;
        //    _this.ProductRepo.Create(product);
        //}
    }
}
