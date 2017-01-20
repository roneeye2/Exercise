using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Framwork.Interface.Entity
{
    public interface IProductCategory : IBaseEntity
    {
        string Discription { get; set; }
        int ParentCategoryId { get; set; }

        ICollection<IProduct> Products { get; set; }
    }
}
