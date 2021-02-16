using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class Doctor: BaseEntity, IAggregateRoot
    {
        [StringLength(150)]
        public string DoctorName { get; set; }
        [StringLength(150)]
        public string Education { get; set; }
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }
        [StringLength(100)]
        public string Experience { get; set; }
        public string Desc { get; set; }
        [StringLength(200)]
        public string DoctorImage { get; set; }
        [StringLength(200)]
        public string Field { get; set; }
        public int StatusId { get; set; }
        public LovStatus Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
