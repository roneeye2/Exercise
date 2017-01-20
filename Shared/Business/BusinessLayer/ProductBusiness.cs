namespace GloboMart.Business
{
    using GloboMart.Framwork.Interface.Business;
    using GloboMart.Framwork.Interface.Data;
    using GloboMart.Framwork.Interface.Entity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProductDomain : IProductDomain
    {
        public IProductRepo repo;
        public ProductDomain(IProductRepo repo)
        {
            this.repo = repo;
        }

        IProduct IProductDomain.Create(IProduct product)
        {
            return repo.Create(product);
        }

        IEnumerable<IProduct> IProductDomain.Read(IProductCategory category)
        {
            return repo.Read();
        }

        IEnumerable<IProduct> IProductDomain.ReadByCategory(IProductCategory category)
        {
            return repo.Read().Where(x => x.ProductCategory == category);
        }

        public bool IProductDomain.Delete(IProduct product)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
