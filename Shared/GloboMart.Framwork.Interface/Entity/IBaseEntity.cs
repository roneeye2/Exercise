using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Framwork.Interface.Entity
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        string Name { get; set; }
        bool IsActive { get; set; }
        DateTime CreatedDate { get; set; }
        int CreatedById { get; set; }
        DateTime UpdatedDate { get; set; }
        int UpdatedById { get; set; }
    }
}
