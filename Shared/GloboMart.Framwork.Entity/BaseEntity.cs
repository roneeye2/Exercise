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
        public int CreatedById { get; set; }
        public int UpdatedById { get; set; }

        private DateTime createdDate;
        public DateTime CreatedDate
        {
            get {
                if (createdDate == null)
                    return DateTime.Now;
                return createdDate; 
            }
            set { createdDate = value; }
        }

        private DateTime updatedDate;
        public DateTime UpdatedDate
        {
            get
            {
                if (updatedDate == null)
                    return DateTime.Now;
                return updatedDate;
            }
            set { updatedDate = value; }
        }
        
    }
}
