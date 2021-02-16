using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class City : BaseEntity, IAggregateRoot
    {
        [StringLength(150)]
        public string CityName { get; set; }
        [StringLength(200)]
        public string CityNameAr { get; set; }
        public int CountryId { get; set; }
        public bool IsActive { get; set; }
        [StringLength(200)]
        public string Logo { get; set; }
    }
}
