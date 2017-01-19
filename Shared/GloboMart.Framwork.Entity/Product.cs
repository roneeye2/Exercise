using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Framwork.Entity
{
    public partial class Product : BaseEntity
    {
        public ProductCategory ProductCategory { get; set; }
    }
}
