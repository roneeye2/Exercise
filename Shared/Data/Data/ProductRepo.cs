namespace GloboMart.Data
{
    using GloboMart.Framwork.Entity;
    using GloboMart.Framwork.Interface.Data;
    using GloboMart.Framwork.Interface.Entity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class ProductRepository : IProductRepo
    {
        private GloboMartContext dbContext;

        public ProductRepository(GloboMartContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IProduct Create(IProduct obj)
        {
            if (obj == null)
                return obj;

            obj = dbContext.Products.Add((Product)obj);
            dbContext.SaveChanges();
            return obj;
        }

        public IEnumerable<IProduct> Read()
        {
            return dbContext.Products;
        }

        public IProduct Read(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IProduct Update(IProduct obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(IProduct obj)
        {
            try
            {
                dbContext.Products.Remove(new Product
                {
                    Id = obj.Id,
                    Name = obj.Name
                });
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (dbContext != null)
                {
                    dbContext.Dispose();
                    dbContext = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
