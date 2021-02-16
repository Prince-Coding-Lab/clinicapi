using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class Offer : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public DateTime ValidUpto { get; set; }
        public decimal OfferValue { get; set; }
        public string Desc { get; set; }
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
