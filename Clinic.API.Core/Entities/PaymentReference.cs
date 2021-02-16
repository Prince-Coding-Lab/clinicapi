using Clinic.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Api.Core.Entities
{
    public class PaymentReference : BaseEntity, IAggregateRoot
    {
        public string ExternalId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
