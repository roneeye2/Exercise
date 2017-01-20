using GloboMart.Framwork.Entity;
using GloboMart.Framwork.Interface.Data;
using GloboMart.Framwork.Interface.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Data
{
    public class ProductCategoryRepository : IProductCategoryRepo
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
              obj = dbContext.ProductCategories.Add(new ProductCategory
              {
                  Name = obj.Name,
                  Discription = obj.Discription,
                  IsActive = true,
              });

              dbContext.SaveChanges();

              return obj;
          }

          public IEnumerable<IProductCategory> Read()
          {
              throw new NotImplementedException();
          }

          public IProductCategory Read(int id)
          {
              throw new NotImplementedException();
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
