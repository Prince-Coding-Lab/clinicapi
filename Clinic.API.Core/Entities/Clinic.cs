using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clinic.Api.Core.Entities
{
   public class Clinic : BaseEntity, IAggregateRoot
    {
        [StringLength(150)]
        public string ClinicName { get; set; }
        public int ClinicCategoryId { get; set; }
        public ClinicCategory ClinicCategory { get; set; }
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public int? CityId { get; set; }
        public City City { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        [StringLength(500)]
        public string ClinicLocation { get; set; }
        [StringLength(250)]
        public string Facebook { get; set; }
        [StringLength(250)]
        public string Twitter { get; set; }
        [StringLength(250)]
        public string Instagram { get; set; }
        [StringLength(250)]
        public string Linkedin { get; set; }
        [StringLength(300)]
        public string Website { get; set; }
        [StringLength(200)]
        public string Logo { get; set; }
        public ICollection<ClinicService> ClinicServices { get; set; }
        public int? CreatedBy { get; set; }
        public User CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public User ModifiedByUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
