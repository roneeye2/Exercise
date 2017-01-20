using GloboMart.Framwork.Interface.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Framwork.Entity
{
    public partial class ProductCategory : BaseEntity, IProductCategory
    {
        public string Discription { get; set; }
        public string LognDiscription { get; set; }
        public int ParentCategoryId { get; set; }

        public ICollection<IProduct> Products { get; set; }
    }
}
