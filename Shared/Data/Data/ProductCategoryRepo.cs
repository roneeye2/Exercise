using GloboMart.Framwork.Entity;
using GloboMart.Framwork.Interface.Data;
using GloboMart.Framwork.Interface.Entity;
using GloboMart.Framwork.Interface.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Data
{
    internal class ProductCategoryRepository : IProductCategoryRepo
    {
          private GloboMartContext dbContext;

          public ProductCategoryRepository(GloboMartContext dbContext)
          {
              this.dbContext = dbContext;
          }

          public IProductCategory Create(IProductCategory obj)
          {
              if (obj == null)
                  return obj;

              obj = dbContext.ProductCategories.Add((ProductCategory)obj);
              dbContext.SaveChanges();

              return obj;
          }

          public IEnumerable<IProductCategory> Read()
          {
              throw new NotImplementedException();
          }

          public IProductCategory Read(eProductCategory category)
          {
              var result = dbContext.ProductCategories.FirstOrDefault(c => c.Name == category);
              return (IProductCategory)result;
          }

          public IProductCategory Update(IProductCategory obj)
          {
              throw new NotImplementedException();
          }

          public bool Delete(IProductCategory obj)
          {
              throw new NotImplementedException();
          }

          public void Dispose()
          {
              throw new NotImplementedException();
          }
    }
}
