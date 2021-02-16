using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class ClinicCategory : BaseEntity, IAggregateRoot
    {
        [StringLength(100)]
        public string CategoryName { get; set; }
        public string CatDescription { get; set; }
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public int? CityId { get; set; }
        public City City { get; set; }
        [StringLength(500)]
        public string CatImage { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ICollection<Clinic> Clinics { get; set; }
    }
}
