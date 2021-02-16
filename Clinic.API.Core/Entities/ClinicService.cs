using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class ClinicService : BaseEntity, IAggregateRoot
    {
        [StringLength(150)]
        public string Title { get; set; }
        public string Desc { get; set; }
        public int ClinicID { get; set; }
        public Clinic Clinic { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
