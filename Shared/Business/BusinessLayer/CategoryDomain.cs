using GloboMart.Framwork.Interface.Business;
using GloboMart.Framwork.Interface.Data;
using GloboMart.Framwork.Interface.Entity;
using GloboMart.Framwork.Interface.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Business
{
    public class CategoryDomain : ICategoryDomain
    {
        public IProductCategoryRepo repo;
        public CategoryDomain(IProductCategoryRepo repo)
        {
            this.repo = repo;
        }

        public IProductCategory Create(IProductCategory category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProductCategory> Read()
        {
            throw new NotImplementedException();
        }

        public IProductCategory ReadByCategory(eProductCategory category)
        {
            return repo.Read(category);
        }

        public bool Delete(IProductCategory product)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            
        }
    }
}
