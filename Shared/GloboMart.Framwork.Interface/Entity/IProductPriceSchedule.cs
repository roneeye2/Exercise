using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Framwork.Interface.Entity
{
    public interface IProductPriceSchedule : IBaseEntity
    {
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        int CurrencyId { get; set; }
    }
}
