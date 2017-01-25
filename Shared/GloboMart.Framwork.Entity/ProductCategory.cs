using GloboMart.Framwork.Interface.Entity;
using GloboMart.Framwork.Interface.Enum;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Framwork.Entity
{
    public partial class ProductCategory : BaseEntity, IProductCategory
    {
        public ProductCategory()
        {
            Products = new List<IProduct>();
        }

        public virtual new eProductCategory Name { get; set; }

        private string _discription = string.Empty;
        public string Discription
        {
            get { return _discription; }
            set { _discription = value; }
        }

        private string lognDiscription = string.Empty;
        public string LognDiscription
        {
            get { return lognDiscription; }
            set { lognDiscription = value; }
        }        

        public int ParentCategoryId { get; set; }

        //[Dependency]
        public ICollection<IProduct> Products { get; set; }
    }
}
