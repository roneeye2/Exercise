using GloboMart.Framwork.Interface.Entity;
using GloboMart.Framwork.Interface.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Framwork.Interface.Data
{
    public interface IProductCategoryRepo : ICRUD<IProductCategory>
    {
        IProductCategory Read(eProductCategory id);
    }
}
