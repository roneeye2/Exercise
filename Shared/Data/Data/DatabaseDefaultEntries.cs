using GloboMart.Framwork.Interface.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using GloboMart.Framwork.Interface.Entity;

namespace GloboMart.Data
{
    public class DatabaseDefaultEntries
    {
        public DatabaseDefaultEntries(
            IProduct _ProductModel,
            IProductCategory _ProductCategoryModel,
            IProductCategoryRepo _ProductCategoryRepo,
            IProductRepo _ProductRepo
            )
        {
            ProductModel = ProductModel;
            ProductCategoryModel = ProductCategoryModel;
            ProductCategoryRepo = ProductCategoryRepo;
            ProductRepo = ProductRepo;
        }

        //[Dependency]
        private static IProduct ProductModel { get; set; }
       // [Dependency]
        private static IProductCategory ProductCategoryModel { get; set; }

        //[Dependency]
        private static IProductCategoryRepo ProductCategoryRepo { get; set; }
        //[Dependency]
        private static IProductRepo ProductRepo { get; set; }

        public static void Execute()
        {
            var category = FillCategories();
            FillProduct(category);
        }

        private static IProductCategory FillCategories()
        {
            var category = ProductCategoryModel;
            category.Name = "Mobile";
            category.IsActive = true;
            category.Discription = "";
            return ProductCategoryRepo.Create(category);
        }

        private static void FillProduct(IProductCategory category)
        {
            var product = ProductModel;
            product.Name = "IPhone";
            product.ProductCategory = category;
            ProductRepo.Create(product);

            product.Name = "Samsung";
            product.ProductCategory = category;
            ProductRepo.Create(product);
        }
    }
}
