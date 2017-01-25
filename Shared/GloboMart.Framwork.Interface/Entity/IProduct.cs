namespace GloboMart.Framwork.Interface.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IProduct : IBaseEntity
    {
        int CategoryId { get; set; }
        IProductCategory ProductCategory { get; set; }
    }
}
