using GloboMart.Framwork.Interface.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Framwork.Entity
{
    public partial class Product : BaseEntity, IProduct
    {
        public Guid CategoryId { get; set; }

        public virtual IProductCategory ProductCategory { get; set; }
    }
}
