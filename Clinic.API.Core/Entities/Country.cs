using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class Country : BaseEntity, IAggregateRoot
    {
        [StringLength(150)]
        public string CountryName { get; set; }
        [StringLength(200)]
        public string CountryNameAr { get; set; }
        public bool IsActive { get; set; }
        [StringLength(200)]
        public string Logo { get; set; }
        [StringLength(10)]
        public string Currency { get; set; }
    }
}
