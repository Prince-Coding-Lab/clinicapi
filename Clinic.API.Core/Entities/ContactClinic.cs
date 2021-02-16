using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class ContactClinic: BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string ContactNumber { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
