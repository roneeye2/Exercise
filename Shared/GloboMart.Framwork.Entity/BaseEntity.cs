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
        public int CreatedById { get; set; }
        public int UpdatedById { get; set; }

        private string name = string.Empty;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        private bool isActive = true;
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
        
        private DateTime createdDate;
        public DateTime CreatedDate
        {
            get {
                if (createdDate == DateTime.MinValue)
                    createdDate = DateTime.Now;
                return createdDate; 
            }
            set { createdDate = value; }
        }

        private DateTime updatedDate;
        public DateTime UpdatedDate
        {
            get
            {
                if (updatedDate == DateTime.MinValue)
                    updatedDate = DateTime.Now;
                return updatedDate;
            }
            set { updatedDate = value; }
        }
        
    }
}
