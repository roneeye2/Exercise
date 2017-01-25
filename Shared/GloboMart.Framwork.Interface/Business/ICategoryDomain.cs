using GloboMart.Framwork.Interface.Entity;
using GloboMart.Framwork.Interface.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Framwork.Interface.Business
{
    public interface ICategoryDomain : IDisposable
    {
        IProductCategory Create(IProductCategory category);
        IEnumerable<IProductCategory> Read();
        IProductCategory ReadByCategory(eProductCategory category);
        bool Delete(IProductCategory product);
    }
}
