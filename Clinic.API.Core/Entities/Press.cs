using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class Press : BaseEntity, IAggregateRoot
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public string PressImage { get; set; }
        public string Source { get; set; }
        public string PostedBy { get; set; }
        public DateTime PostedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
