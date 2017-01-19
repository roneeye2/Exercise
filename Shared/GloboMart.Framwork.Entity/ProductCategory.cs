using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Framwork.Entity
{
    public partial class ProductCategory : BaseEntity
    {
        public string Discription { get; set; }
        public int ParentCategoryId { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
