using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class User : BaseEntity, IAggregateRoot
    {
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [StringLength(150)]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        [StringLength(10)]
        public string CountryCode { get; set; }
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public int? CityId { get; set; }
        public City City { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        public DateTime Lastlogin { get; set; }
        public int StatusId { get; set; }
        public LovStatus Status { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ICollection<Clinic> ClinicsCreated { get; set; }
        public ICollection<Clinic> ClinicsModified { get; set; }
    }
}
