using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloboMart.Framwork.Interface.Entity;

namespace GloboMart.Framwork.Entity
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedById { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedById { get; set; }
    }
}
