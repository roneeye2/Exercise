using GloboMart.Framwork.Interface.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Framwork.Interface.Business
{
    public interface IProductDomain : IDisposable
    {
        IProduct Create(IProduct product);
        IEnumerable<IProduct> Read();
        IEnumerable<IProduct> ReadByCategory(IProductCategory category);
        bool Delete(IProduct product);
    }
}
