﻿using GloboMart.Framwork.Interface.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Framwork.Entity
{
    public partial class ProductPriceSchedule : BaseEntity, IProductPriceSchedule
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CurrencyId { get; set; }
    }
}
