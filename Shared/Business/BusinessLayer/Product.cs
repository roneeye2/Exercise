using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Business
{
    public class Product : IProduct
    {
        void IProduct.Show()
        {
 
        }
    }

    public interface IProduct
    {
        void Show();
    }
}
