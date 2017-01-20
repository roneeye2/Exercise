namespace GloboMart.Data
{
    using GloboMart.Framwork.Entity;
    using GloboMart.Framwork.Interface.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProductRepository : IProductRepo
    {
        private GloboMartContext dbContext;

        public ProductRepository(GloboMartContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Framwork.Interface.Entity.IProduct Create(Framwork.Interface.Entity.IProduct obj)
        {
            if (obj == null)
                return obj;

            dbContext.Products.Add(obj);
            dbContext.SaveChanges();
            return obj;
        }

        public IEnumerable<Framwork.Interface.Entity.IProduct> Read()
        {
            return dbContext.Products;
        }

        public Framwork.Interface.Entity.IProduct Read(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public Framwork.Interface.Entity.IProduct Update(Framwork.Interface.Entity.IProduct obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Framwork.Interface.Entity.IProduct obj)
        {
            try
            {
                dbContext.Products.Remove(obj);
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
