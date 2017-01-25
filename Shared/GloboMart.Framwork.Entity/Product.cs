namespace GloboMart.Framwork.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations.Schema;
    using GloboMart.Framwork.Interface.Entity;

    public partial class Product : BaseEntity, IProduct
    {
        
        public int CategoryId { get; set; }

        private IProductCategory productCategory;
        public virtual IProductCategory ProductCategory
        {
            get { return productCategory; }
            set { 
                productCategory = value;
                CategoryId = productCategory.Id;
            }
        }
        
    }
}
